from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By

driver = webdriver.Chrome("C:\webdriver\chromedriver.exe")
driver.get("https://python.org")
print(driver.title)

search_bar = driver.find_element(By.NAME, "q")
search_bar.clear()
search_bar.send_keys("getting started with python")
search_bar.send_keys(Keys.RETURN)
print(driver.current_url)
driver.close()