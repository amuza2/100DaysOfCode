import scrapy
from scrapy.exceptions import CloseSpider
import json

class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['openlibrary.org']
    start_urls = ['https://openlibrary.org/subjects/juvenile_literature.json?limit=12']
    num = 0

    def parse(self, response):
        if response.status == 400:
            raise CloseSpider("no data to extract")
        
        data = json.loads(response.body)
        ebooks = data.get("works")
        for book in ebooks:
            yield{
                "title":book.get("title"),
                "author":book.get("authors")[0]["name"]
            }
        self.num += 12
        next_page = f'https://openlibrary.org/subjects/juvenile_literature.json?limit=12&offset={self.num}'
        yield response.follow(url=next_page, callback=self.parse)