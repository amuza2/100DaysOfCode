import scrapy
import re


class MainSpider(scrapy.Spider):
    name = 'amazon'
    allowed_domains = ['amazon.com']
    start_urls = ['https://www.amazon.com/s?k=python+3.10']

    def parse(self, response):
        l = []
        for box in response.css(".sg-col-12-of-16 .a-section.a-spacing-small"):
            title = box.css(
                "h2 span::text").get()

            # if title == "Expert Python Programming: Master Python by learning the best coding practices and advanced programming concepts, 4th Edition":
            prices = box.css(".a-price:nth-child(1) span::text").getall()
            book_type = box.css(
                ".s-link-style.a-text-bold::text").getall()
            selected_price = []
            for i in prices:
                if re.fullmatch(r"\$\d+\.\d+", i):
                    selected_price.append(i)
            book_t = {}
            if len(book_type) > 2:
                book_type.remove("Digital")
            print("==>", title)
            print("===>", prices)
            print("===>", book_type)
            print("===>", selected_price)
            if selected_price:
                for j in range(len(book_type)):
                    book_t[book_type[j]] = selected_price[j]
            print("===>", book_t)

            yield {
                "title": title,
                "kindle": [v for b_type, v in book_t.items() if "Kindle" in b_type],
                "Paperback": [v for b_type, v in book_t.items() if "Paperback" in b_type]}
