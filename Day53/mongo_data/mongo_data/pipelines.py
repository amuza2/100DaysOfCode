# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://docs.scrapy.org/en/latest/topics/item-pipeline.html


# useful for handling different item types with a single interface
from itemadapter import ItemAdapter
from pymongo import MongoClient

class MongoDataPipeline:

    def open_spider(self, spider):
        self.client = MongoClient(
                    host = "mongodb+srv://chami:myHardPassword@datascraper.irr0yna.mongodb.net/?retryWrites=true&w=majority",
                    connect = False
            )
        self.collection = self.client.get_database("ebook").get_collection("children")

    def process_item(self, item, spider):
        self.collection.insert_one(ItemAdapter(item).asdict())
        return item

    def close_spider(self, spider):
        self.client.close()
