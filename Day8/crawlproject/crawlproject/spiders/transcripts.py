import scrapy
from scrapy.linkextractors import LinkExtractor
from scrapy.spiders import CrawlSpider, Rule


class TranscriptsSpider(CrawlSpider):
    name = 'transcripts'
    allowed_domains = ['subslikescript.com']
    start_urls = ['https://subslikescript.com/movies_letter-Z']

    rules = (
        Rule(LinkExtractor(restrict_css=(".scripts-list a")), callback='parse_item', follow=True),
        Rule(LinkExtractor(restrict_css=(".pagination_pages [rel='next']")
            ))
    )

    def parse_item(self, response):
        title = response.css(".main-article h1::text").get()
        paragraph = response.css(".plot::text").get()
        transcript = response.css(".full-script::text").getall()

        item = {
            "title":title,
            "paragraph":paragraph,
            "transcript":transcript
        }
        yield item

#next_page = response.css(".pagination_pages li a::attr(href)").getall()[-1]