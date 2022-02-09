from selenium import webdriver
import time

web = "https://twitter.com/"
path = "C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path)
driver.get(web)
driver.maximize_window()

login = driver.find_element_by_css_selector('a[href="/login"]')
login.click()
time.sleep(2)

username = driver.find_element_by_css_selector('input[autocomplete="username"]')
username.send_keys("write username or email")
next_button = driver.find_element_by_css_selector(".r-1f1sjgu+ .r-13qz1uu .r-qvutc0")
next_button.click()
time.sleep(2)

password = driver.find_element_by_css_selector('input[autocomplete="current-password"]')
password.send_keys("write password")
time.sleep(2)

submit = driver.find_element_by_css_selector('[data-testid="LoginForm_Login_Button"]')
submit.click()

