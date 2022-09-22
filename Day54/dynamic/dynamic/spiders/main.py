import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['www.ouedkniss.com']
    start_urls = ['http://www.ouedkniss.com/']

    def parse(self, response):
        pass
