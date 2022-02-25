import scrapy
from scrapy.http import FormRequest
from scrapy.utils.response import open_in_browser
from ..items import ProjectsItem


class QuoteSpider(scrapy.Spider):
    name = 'quotes'
    start_urls = ['http://quotes.toscrape.com/login']

    def parse(self, response):
        token = response.css('form input::attr(value)').extract_first()
        return FormRequest.from_response(response,
                                         formdata={'csrf_token': token,
                                                   'username': 'attreya01@gmail.com',
                                                   'password': 'dsdsadsdsa'
                                                   },
                                         callback=self.start_scraping)

    def start_scraping(self, response):
        print("Logged in!")
        #open_in_browser(response)
        items = ProjectsItem()
        all_div_quotes = response.css('div.quote')

        for quotes in all_div_quotes:
            title = quotes.css('span.text::text').extract()
            author = quotes.css('.author::text').extract()
            tag = quotes.css('.tag::text').extract()
            
            items['title'] = [i.encode("ascii", "ignore").decode("utf-8") for i in title]
            items['author'] = author
            items['tag'] = tag

            yield items
