from selenium import webdriver
from time import sleep


class LoginPage:
    def __init__(self, browser):
        self.driver = browser

    def Login(self, username, password):
        user = self.driver.find_element_by_css_selector("input[name='username']")
        user.send_keys(username)

        passw = self.driver.find_element_by_css_selector('.HmktE [name="password"]')
        passw.send_keys(password)

        submit = self.driver.find_element_by_css_selector(".HmktE button ._4EzTm")
        submit.click()
        sleep(2)
        return self.driver

class HomePage:
    def __init__(self, browser,link):
        self.driver = browser
        try:
            self.driver.get(link)
        except:
            print("no internet connection or too slow")
        self.driver.maximize_window()
        sleep(2)

    def do_login_page(self):
        return LoginPage(self.driver)

    def followers(self, Scroll=True,how_many=2):
        follower = self.driver.find_element_by_css_selector("li:nth-child(2) > a > div")
        follower.click()
        sleep(4)
        scrollDown = self.driver.find_element_by_css_selector("div.isgrP")
        if Scroll:
            items = []
            for i in range(how_many):
                users = self.driver.find_elements_by_css_selector(".PZuss li")
                for user in users:
                    if user not in items:
                        items.append(user)
                    else:
                        items.remove(user)
                for item in items:
                    print(item.find_element_by_css_selector("span a").get_attribute("href"))
                    # print(user.find_element_by_css_selector("span a").text)
                self.driver.execute_script("arguments[0].scrollTop=arguments[0].scrollHeight",scrollDown)
                sleep(3)
        else:
            users = self.driver.find_elements_by_css_selector(".PZuss li")
            for user in users:
                print(user.find_element_by_css_selector("span a").get_attribute("href"))
                # print(user.find_element_by_css_selector("span a").text)
        return self.driver

web = "https://www.instagram.com/"
path = r"C:/SeleniumDrivers/chromedriver.exe"
driver = webdriver.Chrome(path)

def test_login_page(driver):
    home_page = HomePage(driver,web)
    login_page = home_page.do_login_page()
    driver = login_page.Login(username="naninona420", password="moh2009k")
    ines = HomePage(driver, "https://www.instagram.com/inesabdelli.officiel/")
    ines.followers(Scroll=False)

test_login_page(driver)
driver.quit()