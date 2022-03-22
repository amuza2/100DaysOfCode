import scrapy


class JobsSpider(scrapy.Spider):
    name = 'jobs'
    allowed_domains = ['jobs.lk']
    start_urls = ['http://jobs.lk/applicant/vacancybyfunctionalarea.jsp;jsessionid=w0Yij1fxZgR8VX9fS-m2lWRo?FA=HNS']

    def parse(self, response):
        for url in response.css("h2 a::attr(href)").getall():
            url_1 = url.split("JavaScript:openSizeWindow('..")[-1]
            clean_url = "http://jobs.lk"+url_1
            yield response.follow(url=clean_url,callback=self.get_links)

    def get_links(self, response):
        clean_file_url = []    
        png_link = response.css("#remark img::attr(src)").get()
        if png_link != None:
            clean_file_url.append(response.urljoin(png_link))
            yield {"image_urls": clean_file_url}
