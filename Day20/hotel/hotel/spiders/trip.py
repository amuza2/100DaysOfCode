import scrapy
import re

class TripSpider(scrapy.Spider):
    name = 'trip'
    allowed_domains = ['tripadvisor.com']
    start_urls = [f'https://www.tripadvisor.com/Hotel_Review-g55197-d114850-Reviews-or{0}-The_Peabody_Memphis-Memphis_Tennessee.html']


    def parse(self, response):
        profile_url = response.css(".ui_header_link::attr(href)").getall()
        for url in profile_url:
            yield response.follow(url=url, callback=self.profile_items)

    def profile_items(self, response):
        comments = response.css(".fPMlM a::text").get()
        all_comments = response.css("eSYSx.ui_card.section")
        id_profile = (response.url).split('=')[-1]
        for comment in all_comments:
            if int(comments)>20:
                profile_name = comment.css("h1 .Hgccy.b.dWeSQ::text").get()
                id_review = ''.join((comment.css(".bCnPW.Pd a::attr(href)").get()).split('-')[1:4])
                name_business_review = response.css(".LzYdF.b.W.o.q.ui_link::text").get()
                ranking_review = response.css(".emWez.F1 span").get()
                review_date = response.css(".bJaRP._Z.o .wlOhd a::text").get()

                yield {
                    "profile name":profile_name,
                    "profile id":id_profile,
                    "name of company reviewed": name_business_review,
                    "review id": id_review,
                    "company review": ranking_review,
                    "review date": review_date
                }
