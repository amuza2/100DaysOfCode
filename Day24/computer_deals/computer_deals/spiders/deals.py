import scrapy
from scrapy_selenium import SeleniumRequest


class DealsSpider(scrapy.Spider):
    name = 'deals'
    #allowed_domains = ['slickdeals.net']
    page_num = 1

    def start_requests(self):
        yield SeleniumRequest(
            url="https://slickdeals.net/computer-deals/",
            wait_time=3,
            callback=self.parse,
            )

    def parse(self, response):
        #self.page_num +=1

        all_items = response.css("div.fpItem")
        #if len(all_items)>1:
        for product in all_items:
            title = product.css(".bp-p-dealLink::text").get()
            p_link = response.urljoin(product.css(".bp-p-dealLink::attr(href)").get())
            store = product.css(".itemStore::text").get()
            #price = product.css(".itemPrice::text").get() if product.css(".itemPrice::text").get() is not None else ""

            yield {
                "title":title,
                "store":store,
                #"price":price,
                "link":p_link,
            }
            break

            #next_page = f"https://slickdeals.net/computer-deals/?page={self.page_num}"
            #yield SeleniumRequest(url=next_page,wait_time=2, callback=self.parse)