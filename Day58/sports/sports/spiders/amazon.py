import scrapy


class MainSpider(scrapy.Spider):
    name = 'amazon'
    allowed_domains = ['amazon.com']
    start_urls = ['https://www.amazon.com/s?k=python+3.10']

    def parse(self, response):
        l = []
        for i in response.css(".sg-col-12-of-16 .a-section.a-spacing-small"):
            title = response.css(
                "h2 span::text").get()
            prices = i.css(".a-price:nth-child(1) span::text").get()
            book_type = response.css(
                ".s-link-style.a-text-bold::text").getall()
            # l.append({"title":title, })
            for i in prices:
                y = re.findall(r"^\$\d+.\d+$", i)
                if y:
                    print(y)
