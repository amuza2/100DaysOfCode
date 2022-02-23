import scrapy


class PngmartSpider(scrapy.Spider):
    name = 'pngmart'
    #allowed_domains = ['pngmart.com']
    start_urls = ['https://www.pngmart.com/']
   
    def parse(self, response):
        category_links = response.css(".gallery-icon a::attr(href)").getall()
        for link in category_links:
            yield response.follow(url = link, callback=self.image_item)


    def image_item(self, response):
        page_link = response.css(".postlisttitlewrap center a::attr(href)").getall()
        for page in page_link:
            yield response.follow(url=page, callback=self.download_images)
        
        next_page = response.css(".nextpostslink[rel='next']::attr(href)").get()
        if next_page != None:
            yield response.follow(url=next_page, callback=self.image_item)


    def download_images(self, response):
        file_urls = []
        title = response.css("header h1::text").get()
        file = response.css(".download::attr(href)").get()
        file_urls.append(file)
        yield { 
                "title": title,
                "file_urls": file_urls
        }
