import scrapy
from scrapy import FormRequest


class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['quotes.toscrape.com']
    start_urls = ['https://quotes.toscrape.com/login']

    def authentication(self, response):
        if response.css(".row.header-box p a::text").get() == "Logout":
            return True

    def parse(self, response):
        yield FormRequest.from_response(response,
            formdata={"username":"admin", "password":"admin"},
            callback=self.after_login,
            )

    def after_login(self, response):
        if self.authentication(response):
            print("==> Loged in")
