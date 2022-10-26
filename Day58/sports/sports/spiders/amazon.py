import scrapy


class MainSpider(scrapy.Spider):
    name = 'amazon'
    allowed_domains = ['amazon.com']
    start_urls = ['https://www.amazon.com/s?k=python+3.10']

    def parse(self, response):
        titles = response.css(
            ".sg-col-12-of-16 .a-section.a-spacing-small h2 span::text").getall()
        book_type = response.css(
            ".sg-col-12-of-16 .a-section.a-spacing-small .sg-row a::text").get()
