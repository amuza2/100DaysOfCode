from selenium import webdriver
import pandas as pd

website = "https://www.audible.com/search"
path = r"C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path)
driver.get(website)
#driver.maximize_window()

products = driver.find_elements_by_css_selector(".productListItem")

book_title, book_author, book_length = [], [], []

title = "h3.bc-heading.bc-color-link.bc-pub-break-word.bc-size-medium"
author = "li.bc-list-item.authorLabel a"
length = "li.bc-list-item.narratorLabel a"
str_author = " "
for product in products:
	book_title.append(product.find_element_by_css_selector(title).text)

	book_author.append(" ".join([f"{i.text}" for i in product.find_elements_by_css_selector(author)]))
	
	book_length.append(" ".join([f"{j.text}" for j in product.find_elements_by_css_selector(length)]))

driver.quit()

my_audio = {"title":book_title, "author":book_author, "length":book_length}
df = pd.DataFrame(my_audio)
#df.to_csv("audible.csv", index=False)
print(df.head())