import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'

    def start_requests(self):
        yield scrapy.Request(url="https://quotes.toscrape.com/js",
                             meta={"playwright": True})

    def parse(self, response):
        quotes = response.xpath("//div[@class='quote']")
        for quote in quotes:
            theqoute = quote.xpath("./span[@class='text']/text()").get()
            author = quote.xpath(".//small[@class='author']/text()").get()
            tags = quote.xpath(".//div[@class='tags']//a[@class='tag']")
            all_tags = ""
            for tag in tags:
                t = tag.xpath(".//text()").get()
                all_tags += f"{t } "
            tags = all_tags

            yield {
                "Quote": theqoute,
                "Author": author,
                "Tags": tags
            }
