import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['quotes.toscrape.com']
    start_urls = ['http://quotes.toscrape.com/login']


    def parse(self, response):
        url = "http://quotes.toscrape.com/login"
        csrf = response.xpath("//form/input/@value").get()
        yield scrapy.FormRequest(url=url, formdata={"username":"amuza","password":"mypassword","csrf_token":csrf}, callback=self.loged_in)
        
    def loged_in(self, response):
        print("Login done!")
        print(response.xpath("//div[@class='quote']/span[@class='text']/text()").get())
        
