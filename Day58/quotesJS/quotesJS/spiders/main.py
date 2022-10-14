import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'

    def start_requests(self):
        yield scrapy.Request(url="http://quotes.toscrape.com/js",
                             meta={"playwright": False})

    def parse(self, response):
        yield {
            "html": str(response.body)
        }
