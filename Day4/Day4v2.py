from selenium import webdriver
# from selenium.webdriver.support.ui import WebDriverWait
# from selenium.webdriver.common.by import By
# from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.chrome.options import Options
import pandas as pd

option = Options()
option.headless = True
option.add_argument("window-size=1600x900")

url = "https://www.audible.com/adblbestsellers"
path = "C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path,options=option)
driver.get(url)
# driver.maximize_window()

max_page = int(driver.find_elements_by_css_selector(".linkListWrapper .bc-link.refinementFormLink.pageNumberElement")[1].text)
l_name, l_author = [],[]

for j in range(max_page):
	audio_books = driver.find_elements_by_css_selector(".bc-col-responsive.bc-col-6")
	for item in audio_books:	
		name = item.find_element_by_css_selector("h3 a")
		author = item.find_elements_by_css_selector(".bc-list-item.authorLabel a")

		l_name.append(name.text)
		l_author.append(' '.join([i.text for i in author]))

	next_page = driver.find_element_by_css_selector(".bc-button.bc-button-secondary.nextButton")
	next_page.click()
	driver.implicitly_wait(2)

driver.quit()

data = {"book name": l_name, "author":l_author}
df = pd.DataFrame(data)
df.to_csv("audio_book.csv", index=False)
