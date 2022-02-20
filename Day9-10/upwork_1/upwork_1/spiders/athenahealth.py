import scrapy
from ..items import Upwork1Item
import re

class AthenahealthSpider(scrapy.Spider):
    name = 'athenahealth'

    def start_requests(self):
        for n in range(1,100000):
            url = f"https://{n}.portal.athenahealth.com"
            yield scrapy.Request(url=url,callback=self.parse) 


    def parse(self, response):
        item = Upwork1Item()
        name = response.css("#email-login-page h1::text").get(default="empty")
        if response.status == 200 and name != "empty":
            pattern_1 = "Welcome to"
            pattern_2 = "Patient Portal"
            x = re.split(r"^(Welcome to)|(Patient Portal)", name)
            for i in x:
                if i != '' and i != None and i != pattern_1 and i != pattern_2:
                    name = i

            item["name"] = name
            item["url"] = response.url

            yield item
