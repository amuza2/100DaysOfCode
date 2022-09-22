import scrapy
import json

class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['quotes.toscrape.com']
    start_urls = ['https://quotes.toscrape.com/api/quotes?page=1']
    n = 1

    def parse(self, response):
        data = json.loads(response.body)
        for page_data in data.get("quotes"):
            
            yield {
                    "author" : page_data.get("author").get("name"),
                    "tags" : ','.join(page_data.get("tags")),
                    "text" : page_data.get("text")

                }
        self.n += 1 
        url = "https://quotes.toscrape.com/api/quotes?page=" + str(self.n)
        if data.get("has_next"):
            yield response.follow(url, callback=self.parse)