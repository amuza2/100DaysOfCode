import scrapy
import json
from scrapy.exceptions import CloseSpider


class BookSpider(scrapy.Spider):
    name = 'book'
    n = 0
    start_urls = ['https://openlibrary.org/subjects/picture_books.json?limit=12&offset=0']

    def parse(self, response):
        if response.status == 500:
            raise CloseSpider("reached last page")

        resp = json.loads(response.body)
        num_of_ebooks = resp.get("works")
        for book in num_of_ebooks:
            yield {
                "title" : book.get("title"),
                "tag" : book.get("subject")
                #author = book.get("authors")

            }
        self.n += 12
        yield scrapy.Request(url=f'https://openlibrary.org/subjects/picture_books.json?limit=12&offset={self.n}',
                        callback=self.parse
            )