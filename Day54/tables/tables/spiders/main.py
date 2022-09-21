import scrapy
from tables.items import TablesItem
from scrapy.loader import ItemLoader

class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['books.toscrape.com']
    start_urls = ['https://books.toscrape.com/catalogue/scott-pilgrims-precious-little-life-scott-pilgrim-1_987/index.html']

    def parse(self, response):
        item = TablesItem()
        my_dict = {}
        for value in response.xpath("//table/tr"):
            heading = value.xpath(".//th/text()").get()
            data = value.xpath(".//td/text()").get()

            item["heading"] = heading
            item["data"] = data
            my_dict[heading] = data
        
        yield my_dict

