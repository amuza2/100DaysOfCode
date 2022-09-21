import scrapy
from tables.items import TablesItem
from scrapy.loader import ItemLoader

class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['books.toscrape.com']
    start_urls = ['https://books.toscrape.com/catalogue/scott-pilgrims-precious-little-life-scott-pilgrim-1_987/index.html']

    def parse(self, response):
        item = TablesItem()
        for value in response.xpath("//table[@class='table table-striped']"):
            heading = value.xpath(".//tr/th").get()
            data = value.xpath(".//tr/td").get()

            item["heading"] = heading
            item["data"] = data
        yield item

