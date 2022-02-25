# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://docs.scrapy.org/en/latest/topics/item-pipeline.html


# useful for handling different item types with a single interface
from itemadapter import ItemAdapter
from scrapy.pipelines.images import ImagesPipeline
from slugify import slugify
import os
import hashlib
from scrapy.utils.python import to_bytes


class ImageDownloaderPipeline(ImagesPipeline):
    def file_path(self, request, response=None, info=None, *, item=None):
        file_name = hashlib.sha1(to_bytes(request.url)).hexdigest() 
        return f"{item['listingUrlSlug']}/{item['listingUrlSlug']}-{slugify(file_name, max_length=200)}.jpg"
