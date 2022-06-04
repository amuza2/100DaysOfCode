"""
create an app that calculate the amount of any person
stayes in a house accourding on the days he/she stayed.

names: amount, person, house, days
30 days ==> 30 dollars
15 days ==> x
x = (15 * 30)/ 30
"""

import fpdf
from datetime import datetime, timedelta


class Client:

    def __init__(self, name, phone):
        self.name = name
        self.phone = phone
        self.date = datetime.strptime(datetime.now().strftime("%Y %m %d"),"%Y %m %d")


    def update_info(self, name, phone, date):
        self.name = name
        self.phone = phone
        date = date.split()
        self.date = datetime(int(date[0]), int(date[1]), int(date[2]))

class Flat:

    def __init__(self):
        self.fees = 20000
        self.people_in_flat = {}
        self.days_in_month = 30

    def set_attribute(self,name,value):
        self.__dict__[name] = value

    def add_person(self, client):
        # set_attribute(client.name, client)
        self.people_in_flat[client.name] = client
        print(f"Client {client.name} has been added")


    def bill(self):
        part = self.fees / len(self.people_in_flat.keys())

        for k,v in self.people_in_flat.items():
            days_in_flat = datetime(v.date.year, v.date.month+1, 1) - v.date
            cost = (part * (days_in_flat.days-1)) // self.days_in_month
            setattr(Flat, "cost", cost)
            # print(f"{v.name} spent {days_in_flat.days-1} days, he has to pay: {cost}")

        # print(self.people_in_flat.__dict__)


class CreatePDFReport:
    def __init__(self, filename):
        self.filename = filename

    def to_pdf(self, flat):
        pdf = fpdf.FPDF('p','pt','A4')
        pdf.add_page()
        pdf.set_font(family="Times",size=24,style='B')
        pdf.cell(w=0,h=80,txt="Flatmates Bill",border=1,align='C',ln=1)
        pdf.cell(w=100,h=40,txt="Period:",border=1)
        pdf.set_font(family="Times",size=24,style='')
        c = 1
        for i in flat.people_in_flat.values():
            if c == 1:
                pdf.cell(w=120,h=40,txt=f"{i.date.year} - {i.date.month}",border=1,ln=1)
                pdf.cell(w=0,h=100,txt="",ln=1)
                c = 0
            pdf.cell(w=110,h=40,txt=f"{i.name}:",border=1)
            pdf.cell(w=110,h=40,txt=f"{flat.cost}",border=1,ln=1)            


        pdf.output(f"{self.filename}.pdf")


flat = Flat()

med = Client("med", 1234)
zim = Client("zim", 5678)
zue = Client("zue", 9874)
zim.update_info(name="zim",phone="1234",date="2022 06 15")
flat.add_person(med)
flat.add_person(zim)
flat.add_person(zue)
flat.bill()


export = CreatePDFReport("invoice")
export.to_pdf(flat)