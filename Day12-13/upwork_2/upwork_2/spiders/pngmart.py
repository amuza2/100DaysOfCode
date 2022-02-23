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
        file_urls = []
        title = response.css("header h1::text").get()
        file = response.css(".download::attr(href)").get()
        file_urls.append(response.urljoin(file))
        yield { 
                "title": title,
                "file_urls": file_urls
        }
