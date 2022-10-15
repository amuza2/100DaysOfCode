import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'

    def start_requests(self):
        yield scrapy.Request(url="https://quotes.toscrape.com/js",
                             meta={"playwright": True})

    def parse(self, response):
        quotes = response.xpath("[class='quote']")
        for quote in quotes:
            theqoute = quote.xpath("[class='text']").get()
            author = quote.xpath("[class='author']").get()
            tags = quote.xpath("[class='tags'] [class='tag']")
            all_tags = ""
            for tag in tags:
                all_tags += f"{tag} "
            tags = all_tags

            yield {
                "Quote": theqoute,
                "Author": author,
                "Tags": tags
            }
