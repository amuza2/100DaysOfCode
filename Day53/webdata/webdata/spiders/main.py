import scrapy
from webdata.items import WebdataItem
from urllib.parse import urljoin
from scrapy.loader import ItemLoader

class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['books.toscrape.com']
    start_urls = ['https://books.toscrape.com/']

    def parse(self, response):
        print("---- Scraping ----")

        for box in response.xpath("//article[@class='product_pod']"):
            data = ItemLoader(item=WebdataItem(), selector=box)
            data.add_xpath("url", ".//h3/a/@href")
            data.add_xpath("title", ".//h3/a/@title")
            data.add_xpath("price", ".//p[@class='price_color']/text()")

            yield data.load_item()