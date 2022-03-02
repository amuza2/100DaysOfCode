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
            title = quotes.css('span.text::text').getall()
            author = quotes.css('.author::text').getall()
            tag = quotes.css('.tag::text').getall()

            for j in range(len(title)):            
                items['title'] = title[j].encode("ascii", "ignore").decode("utf-8")
                items['author'] = author[j]
                tag = "".join(tag[j])
                items['tag'] = tag

            yield items
