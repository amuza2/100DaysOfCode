import scrapy
from scrapy_selenium import SeleniumRequest
from ..items import QuotesItem


class MainSpider(scrapy.Spider):
    name = 'main'

    def start_requests(self):
        url = 'http://quotes.toscrape.com/js/'
        yield SeleniumRequest(url=url, callback=self.parse, wait_time=10)

    def parse(self, response):
        quote_item = QuotesItem()
        for quote in response.css("div.quote"):
            quote_item["text"] = quote.css("span.text::text").get()
            quote_item["author"] = quote.css("small.author::text").get()
            quote_item["tags"] = quote.css("div.tags a.tag::text").getall()
            yield quote_item
