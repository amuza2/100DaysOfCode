import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['books.toscrape.com']
    start_urls = ['http://books.toscrape.com/']

    def parse(self, response):
        print("---- Scraping ----")

        print(response.xpath("//h3/a/@href").get())