import scrapy
from scrapy_selenium import SeleniumRequest
from scrapy.selector import Selector


class YoutubeSpider(scrapy.Spider):
    name = 'youtube' 
    start_urls = ["https://www.youtube.com/user/jacksfilms/videos"]
    headers = {
        "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36",
        "connection": "keep-alive",
        "upgrade-insecure-requests": '1',
        "accept-language": "en-GB,en;q=0.5",
        "accept_encoding": "gzip, deflate, bc",
        "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"      
    }

    def start_requests(self):
        yield SeleniumRequest(wait_time=3, url=self.start_urls[0],screenshot=True, callback=self.parse)
    
    def parse(self, response):
        driver = Selector(response.body)
        #with open("screenshot.png", "wb") as f:
        #    f.write(img) 
        titles = response.css(".ytd-grid-renderer #video-title::attr(href)").getall()
        yield {"titles": titles}
        
    def item_scrape(self, response):
        pass