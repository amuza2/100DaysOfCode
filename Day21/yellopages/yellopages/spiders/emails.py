import scrapy


class EmailsSpider(scrapy.Spider):
    name = 'emails'
    allowed_domains = ['zlatestranky.sk']
    start_urls = ['https://www.zlatestranky.sk/firmy/-/q_adit%C3%ADva/1/']

    def parse(self, response):
        result = response.css("a[data-ta='EmailClick']::text").getall()
        for i in range(len(result)):
            yield {"emails":result[i]}
