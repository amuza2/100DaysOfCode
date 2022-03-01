import scrapy
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from upwork_4.items import Upwork4Item
from scrapy_splash import SplashRequest

class YoutubeSpider(scrapy.Spider):
    name = 'youtube' 

    def start_requests(self):
        """
        options = Options()
        options.headless = True
        options.add_argument("window-size=1600x900")
        path = r"C:/SeleniumDrivers/chromedriver.exe"
        driver = webdriver.Chrome(path, options=options)
        driver.get(website)
        #vids = driver.find_elements_by_css_selector("div #items .ytd-grid-renderer h3 a::attr(href)")
        #yield splashRequest(url=website)
        #f"www.youtube.com{vids}
        driver.quit()
        """
        website = "https://www.youtube.com/user/jacksfilms/videos"
        yield SplashRequest(website)

    def parse(self, response):
        #item = Upwork4Item()
        #item["title"] = response.css(".title .ytd-video-primary-info-renderer::text").get()
        title = response.css("div #items .ytd-grid-renderer h3 a::attr(href)").getall()
        yield {"title":title}