import scrapy
from ..items import PopulationItem


class PeopleSpider(scrapy.Spider):
    name = 'people'
    allowed_domains = ['worldometers.info']
    start_urls = ['https://www.worldometers.info/world-population/population-by-country/']


    def parse(self, response):
        for box in response.css("tbody tr"):
            #row_data = box.css("td::text").getall()
            link = box.css("td a::attr('href')").get()
            country = box.css("td a::text").get()
            yield response.follow(url=link, callback=self.follow_link, meta = {"country": country})
            

    def follow_link(self, response):
        item = PopulationItem()
        country = response.request.meta["country"]
        for i in response.css(".table-responsive:nth-child(7) tbody tr"):
            all_data = i.css("td::text").getall()
            pop = i.css("td strong::text").get()
            item["year"] = all_data[0]
            item["country"] = country
            item["yearly_change_ratio"]=all_data[1]
            item["yearly_change"]=all_data[2]
            item["migrants"]=all_data[3]
            item["med_age"]=all_data[4]
            item["fert_rate"]=all_data[5]
            item["density"]=all_data[6]
            item["urban_pop_ratio"]=all_data[7]
            item["urban_pop"]=all_data[8]
            item["country_share_of_pop"] = all_data[9]
            item["world_pop"] = all_data[10]
            item["global_rank"] = all_data[11]
            item["population"]=pop

            yield item

