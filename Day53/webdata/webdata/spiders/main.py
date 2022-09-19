import scrapy
from webdata.items import WebdataItem
from urllib.parse import urljoin
from scrapy.loader import ItemLoader

class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['books.toscrape.com']
    start_urls = ['https://books.toscrape.com/catalogue/category/books/sequential-art_5/index.html']

    def parse(self, response):
        print("---- Scraping ----")

        for box in response.xpath("//article[@class='product_pod']"):
            url = box.xpath(".//h3/a/@href").get()
            yield response.follow(url=url, callback=self.get_details)


    def get_details(self, response):
        box = response.xpath('//div[@class="col-sm-6 product_main"]')
        data = ItemLoader(item=WebdataItem(), selector=box)
        data.add_xpath("title", "//h1/text()")
        data.add_xpath("price", "//p[@class='price_color']/text()")
        data.add_value("url", response.url)
        data.add_xpath("available", "//p[@class='instock availability']")
        yield data.load_item()


        # next_page = response.xpath("//li[@class='next']/a/@href").get()
        # if next_page:
        #     yield response.follow(url=next_page, callback=self.parse)