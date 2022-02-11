# Define here the models for your scraped items
#
# See documentation in:
# https://docs.scrapy.org/en/latest/topics/items.html

import scrapy


class PopulationItem(scrapy.Item):
    # define the fields for your item here like:
    # name = scrapy.Field()
    year = scrapy.Field()
    country = scrapy.Field()
    population = scrapy.Field()
    yearly_change = scrapy.Field()
    yearly_change_ratio = scrapy.Field()
    migrants = scrapy.Field()
    med_age = scrapy.Field()
    fert_rate = scrapy.Field()
    density = scrapy.Field()
    urban_pop = scrapy.Field()
    urban_pop_ratio = scrapy.Field()
    country_share_of_pop = scrapy.Field()
    world_pop = scrapy.Field()
    global_rank = scrapy.Field()