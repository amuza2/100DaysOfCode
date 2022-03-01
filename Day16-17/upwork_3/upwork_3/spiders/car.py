import scrapy
import json


class CarSpider(scrapy.Spider):
    name = 'car'
    page = 1
    start_urls = ['https://finder.porsche.com/api/ca/en-CA/search?orderBy=price_desc&distanceUnit=kilometer&condition=used&sellers=1606&page=1']

    def parse(self, response):
        resp = json.loads(response.body)
        all_items = resp.get("results")
        if all_items:
            for item in all_items:
                title = item.get("description").get("title")
                title = title.encode("ascii", "ignore").decode("utf-8") if title is not None else ""
                consuption = item.get("description").get("consumptionEmission")
                consuption = consuption.encode("ascii", "ignore").decode("utf-8") if consuption is not None else ""
            
                yield {
                    "online_Orderable_State": item.get("description").get("onlineOrderableState"),
                    "subtitle": item.get("description").get("subtitle"),
                    "title": title,
                    "price": item.get("description").get("price"),
                    "consumption_Emission": consuption,
                    "model_Series": item.get("description").get("modelSeries"),
                    "color": item.get("meta").get("color"),
                    "condition": item.get("meta").get("condition"),
                    "interior_Color": item.get("meta").get("interiorColor"),
                    "mileage": item.get("meta").get("mileage"),
                    "model": item.get("meta").get("model"),
                    "number_Of_PreviousOwners": item.get("meta").get("numberOfPreviousOwners"),
                    "priceCurrency": item.get("meta").get("priceCurrency"),
                    "transmission": item.get("meta").get("transmission"),
                    "warranty": item.get("meta").get("warranty"),
                    "listingUrlSlug": item.get("listingUrlSlug"),
                    "image_urls": [f"https://cdn.images.slfinpub.aws.porsche.cloud/{i}/960x720" for i in item.get("gallery").get("imageIds")]
                }
            self.page += 1
            yield scrapy.Request(url=f"https://finder.porsche.com/api/ca/en-CA/search?orderBy=price_desc&distanceUnit=kilometer&condition=used&sellers=1606&page={self.page}", callback=self.parse)