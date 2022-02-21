import scrapy


class Way1Spider(scrapy.Spider):
    name = 'way_1'
    allowed_domains = ['en.wikipedia.org']
    start_urls = ['https://en.wikipedia.org/wiki/Tokyo']

    def parse(self, response):
        row_image_urls = response.css(".mw-made-collapsible .infobox-above , .thumb img::attr(src)").getall()
        clean_img_urls = []
        for img_url in row_image_urls:
            clean_img_urls.append(response.urljoin(img_url))

        yield {"image_urls" : clean_img_urls}