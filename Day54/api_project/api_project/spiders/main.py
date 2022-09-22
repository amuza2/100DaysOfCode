import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['quotes.toscrape.com']
    start_urls = ['http://quotes.toscrape.com/']

    def parse(self, response):
        pass
