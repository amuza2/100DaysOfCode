import scrapy


class MainSpider(scrapy.Spider):
    name = 'main'
    allowed_domains = ['espn.com']
    start_urls = ['https://www.espn.com/soccer/table/_/league/eng.1']

    def parse(self, response):
        gp, w, d, l, f, a, gd, p = [], [], [], [], [], [], [], []

        teams = response.css(".Table__TD .hide-mobile a::text").getall()
        # header = response.css(
        # ".Table__Scroller .Table__header-group.Table__THEAD a::text").getall()
        table = response.css(
            ".Table__Scroller .Table__TBODY .Table__TR.Table__TR--sm.Table__even")
        for row in table:
            values = row.css("td span::text").getall()
            gp.append(values[0])
            w.append(values[1])
            d.append(values[2])
            l.append(values[3])
            f.append(values[4])
            a.append(values[5])
            gd.append(values[6])
            p.append(values[7])

        for c in range(len(teams)):
            yield{
                "TEAMS": teams[c],
                "GP": gp[c],
                "w": w[c],
                "d": d[c],
                "l": l[c],
                "f": f[c],
                "a": a[c],
                "gd": gd[c],
                "p": p[c],
            }
