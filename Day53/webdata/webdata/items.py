# Define here the models for your scraped items
#
# See documentation in:
# https://docs.scrapy.org/en/latest/topics/items.html

import scrapy
from itemloaders.processors import MapCompose, TakeFirst
from urllib.parse import urljoin
import re

def remove_currency(value):
    return value.replace('£', '')

def join_url(value):
    return urljoin("https://books.toscrape.com/", value)

def available_book(value):
    result = "".join(re.findall(r"\d+", value))
    return result   
    
class WebdataItem(scrapy.Item):
    # define the fields for your item here like:
    title = scrapy.Field(output_processor = TakeFirst())

    price = scrapy.Field(input_processor = MapCompose(remove_currency),
                         output_processor=TakeFirst())

    url = scrapy.Field(input_processor = MapCompose(join_url),
                        output_processor=TakeFirst())

    available = scrapy.Field(input_processor=MapCompose(available_book),
                            output_processor=TakeFirst())
