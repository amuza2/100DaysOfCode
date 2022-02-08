from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import pandas as pd
import time

options = Options()
options.headless = True
options.add_argument("window-size=1600x900")

website = "https://www.audible.com/adblbestsellers?ref=a_search_t1_navTop_pl0cg1c0r0&pf_rd_p=fe7365e8-61ba-4d50-b524-df73bbd8631f&pf_rd_r=8X1BMQSBXWYTZFYEWCZJ"
path = r"C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path, options=options)
driver.get(website)

length = driver.find_elements_by_css_selector("ul.bc-list.pagingElements.bc-list-nostyle.bc-list-horizontal a")
page = 1
max_page = int(length[-2].text)
a_title, a_author, a_narration, a_length = [], [], [], []

while page <= max_page:
	time.sleep(1)
	box = driver.find_elements_by_css_selector(".bc-list-item.productListItem")
	for item in box:
		title = item.find_element_by_css_selector(".bc-heading.bc-color-link.bc-pub-break-word.bc-size-medium a")
		author = item.find_elements_by_css_selector(".bc-list-item.authorLabel a")
		Narrator = item.find_elements_by_css_selector(".bc-list-item.narratorLabel a")
		audio_length = item.find_element_by_css_selector(".bc-list-item.runtimeLabel span")

		a_title.append(title.text)
		a_author.append(" ".join([i.text for i in author]))
		a_narration.append(" ".join([i.text for i in Narrator]))
		a_length.append(audio_length.text)

	page +=1

	try:
		next_page = driver.find_element_by_css_selector(".bc-button.bc-button-secondary.nextButton.refinementFormButton.bc-button-small.bc-button-inline")
		next_page.click()
	except:
		pass
driver.quit()

my_audio = {"title":a_title, "author":a_author,"narration":a_narration ,"length":a_length}
df = pd.DataFrame(my_audio)
df.to_csv("audible_best_sellers.csv", index=False)
print(df.head())
