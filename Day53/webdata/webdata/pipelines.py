# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://docs.scrapy.org/en/latest/topics/item-pipeline.html


# useful for handling different item types with a single interface
from itemadapter import ItemAdapter
from openpyxl import Workbook


class WebdataPipeline:
    cols = ["Name", "price", "url"]

    def open_spider(self, spider):
        self.workbook = Workbook()
        self.sheet = self.workbook.active
        self.sheet.title = "ebooks"
        self.sheet.append(self.cols)

    def process_item(self, item, spider):
        self.sheet.append([item["title"], item["price"], item["url"]])
        return item

    def close_spider(self, spider):
        self.workbook.save("ebooks.xlsx")
