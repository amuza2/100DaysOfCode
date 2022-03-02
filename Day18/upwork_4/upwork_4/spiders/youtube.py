import scrapy
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import time
#from upwork_4.items import Upwork4Item
#from scrapy_splash import SplashRequest

class YoutubeSpider(scrapy.Spider):
    name = 'youtube' 
    #start_urls = ["https://www.youtube.com/user/jacksfilms/videos"]
    start_urls = ["https://quotes.toscrape.com/"]
    headers = {
        "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36",
        "connection": "keep-alive",
        "upgrade-insecure-requests": '1',
        "accept-language": "en-GB,en;q=0.5",
        "accept_encoding": "gzip, deflate, bc",
        "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"      
    }
    #def start_requests(self):
    def parse(self, response):
        path = r"C:/SeleniumDrivers/chromedriver.exe"
        options = Options()
        options.headless = True
        options.add_argument("window-size=1600x900")
        driver = webdriver.Chrome(path, options=options)
        driver.get(self.start_urls[0])
        time.sleep(5)
        html = driver.page_source
        #titles = driver.find_elements_by_css_selector("h3 #video-title")
        #titles = html.find_elements_by_css_selector(".author")
        titles = html.css(".author").getall()

        #vids = driver.find_elements_by_css_selector("div #items .ytd-grid-renderer h3 a::attr(href)")
        #yield splashRequest(url=website)
        #f"www.youtube.com{vids}
        for i in titles:
            yield {"title":i.text}
        driver.quit()

    #def parse(self, response):
        #item = Upwork4Item()
        #item["title"] = response.css(".title .ytd-video-primary-info-renderer::text").get()
        #title = response.css("div #items .ytd-grid-renderer h3 a::attr(href)").getall()
        #yield {"title":title}