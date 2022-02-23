import scrapy


class PngmartSpider(scrapy.Spider):
    name = 'pngmart'
    #allowed_domains = ['pngmart.com']
    start_urls = ['https://www.pngmart.com/image/category/animals']
   
    def parse(self, response):
        links = response.css(".postlisttitlewrap center a::attr(href)").getall()
        for link in links:
            yield response.follow(url = link, callback=self.image_item)

    def image_item(self, response):
        image_urls = []
        title = response.css("header h1::text").get()
        image = response.css(".download::attr(href)").get()
        image_urls.append(response.urljoin(image))
        yield { 
                "title": title,
                "image_urls": image_urls
        }
