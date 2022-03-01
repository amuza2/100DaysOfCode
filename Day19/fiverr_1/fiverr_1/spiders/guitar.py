import scrapy
from fiverr_1.items import Fiverr1Item


class GuitarSpider(scrapy.Spider):
    name = 'guitar'
    start_urls = ['https://www.sweetwater.com/c600--6_string_Acoustic_Guitars']
    custom_headers = {
        "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.71 Safari/537.36",
        "connection": "keep-alive",
        "upgrade-insecure-requests": '1',
        "accept-language": "en-GB,en;q=0.5",
        "accept_encoding": "gzip, deflate, bc",
        "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"      
    }
    

    def parse(self, response):
        urls = response.css("h2.product-card__name ::attr(href)").getall()
        for i in urls:
            page = f"https://www.sweetwater.com{i}"
            yield response.follow(url=page, headers=self.custom_headers, callback=self.items_scraped)

    def items_scraped(self, response):
        item = Fiverr1Item()
        item["title"]= "".join(response.css("h1.product__name span::text").getall()),

        item["price"]= response.css(".product-price--final dollars::text").get().strip() if response.css(".product-price--final dollars::text").get() is not None else "",
        item["url"]= response.url,
        item["body_shape"]= response.css(".table__row:nth-child(3) span::text").get().strip() if response.css(".table__row:nth-child(3) span::text").get() is not None else "",
        item["Left_Right_handed"]= response.css(".table__row:nth-child(4) span::text").get().strip() if response.css(".table__row:nth-child(4) span::text").get() is not None else "",
        item["Color"]= response.css(".table__row:nth-child(5) span::text").get().strip() if response.css(".table__row:nth-child(5) span::text").get() is not None else "",
        item["Finish"]= response.css(".table__row:nth-child(6) span::text").get().strip() if response.css(".table__row:nth-child(6) span::text").get() is not None else "",
        item["Top_Wood"]= response.css(".table__row:nth-child(7) span::text").get().strip() if response.css(".table__row:nth-child(7) span::text").get() is not None else "",
        item["Back_Sides_Wood"]= response.css(".table__row:nth-child(8) span::text").get().strip() if response.css(".table__row:nth-child(8) span::text").get() is not None else "",
        item["Body_Bracing"]= response.css(".table__row:nth-child(9) span::text").get().strip() if response.css(".table__row:nth-child(9) span::text").get() is not None else "",
        item["Neck_Wood"]= response.css(".table__row:nth-child(10) span::text").get().strip() if response.css(".table__row:nth-child(10) span::text").get() is not None else "",
        item["Neck_Shape"]= response.css(".table__row:nth-child(11) span::text").get().strip() if response.css(".table__row:nth-child(11) span::text").get() is not None else "",
        item["Radius"]= response.css(".table__row:nth-child(12) span::text").get().strip() if response.css(".table__row:nth-child(12) span::text").get() is not None else "",
        item["Fingerboard_Material"]= response.css(".table__row:nth-child(13) span::text").get().strip() if response.css(".table__row:nth-child(13) span::text").get() is not None else "",
        item["Fingerboard_Inlay"]= response.css(".table__row:nth-child(14) span::text").get().strip() if response.css(".table__row:nth-child(14) span::text").get() is not None else "",
        item["Nut_Saddle_Material"]= response.css(".table__row:nth-child(19) span::text").get().strip() if response.css(".table__row:nth-child(19) span::text").get() is not None else "",
        item["Nut_Width"]= response.css(".table__row:nth-child(20) span::text").get().strip() if response.css(".table__row:nth-child(20) span::text").get() is not None else ""
     
        yield item
