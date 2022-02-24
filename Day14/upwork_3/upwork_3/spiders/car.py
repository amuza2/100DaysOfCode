import scrapy


class CarSpider(scrapy.Spider):
    name = 'car'
    allowed_domains = ['dealer.porsche.com']
    start_urls = ['http://dealer.porsche.com/']

    def parse(self, response):
        pass
