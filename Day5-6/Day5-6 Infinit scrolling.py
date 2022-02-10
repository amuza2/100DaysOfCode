from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time
import pandas as pd

web = "https://twitter.com/TwitterSupport"
path = "C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path)
driver.get(web)
driver.maximize_window()

def get_twit(element):
	try:
		tag = element.find_element_by_css_selector('[role="link"] [dir="ltr"] span').text
		content = element.find_element_by_css_selector('[lang="en"]').text	
		twits_data = [tag, content]
	except:
		twits_data = ["user", "text"]
	return twits_data

scrolling = True
card_name, card_content = [], []
while scrolling:
	twits = WebDriverWait(driver, 5).until(EC.presence_of_all_elements_located((By.CSS_SELECTOR, 'article[role="article"]')))
	for twit in twits:
		twit_list = get_twit(twit)
		content = " ".join(twit_list[1].split())
		content = content.encode("ascii", "ignore").decode("utf-8")
		if content not in card_content:
			card_name.append(twit_list[0])
			card_content.append(content)
	
	last_page = driver.execute_script("return document.body.scrollHeight")
	while True:
		driver.execute_script("window.scrollTo(0, document.body.scrollHeight);")
		time.sleep(2)
		new_page = driver.execute_script("return document.body.scrollHeight")
		if last_page == new_page:
			scrolling = False
			break
		last_page = new_page
		break

driver.quit()
data = {"tag": card_name, "content": card_content}
df = pd.DataFrame(data)
df.to_csv("twitter_infinit_scrolling.csv", index = False)
print(df.head())
