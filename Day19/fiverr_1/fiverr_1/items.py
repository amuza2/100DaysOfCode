# Define here the models for your scraped items
#
# See documentation in:
# https://docs.scrapy.org/en/latest/topics/items.html

import scrapy


class Fiverr1Item(scrapy.Item):
    # define the fields for your item here like:
    # name = scrapy.Field()
    title = scrapy.Field()
    price = scrapy.Field()
    url = scrapy.Field()
    body_shape = scrapy.Field()
    Left_Right_handed = scrapy.Field()
    Color = scrapy.Field()
    Finish = scrapy.Field()
    Top_Wood = scrapy.Field()
    Back_Sides_Wood = scrapy.Field()
    Body_Bracing = scrapy.Field()
    Neck_Wood = scrapy.Field()
    Neck_Shape = scrapy.Field()
    Radius = scrapy.Field()
    Fingerboard_Material = scrapy.Field()
    Fingerboard_Inlay = scrapy.Field()
    Nut_Saddle_Material = scrapy.Field()
    Nut_Width = scrapy.Field()
