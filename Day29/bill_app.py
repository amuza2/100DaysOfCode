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


    def add_person(self, client):
        self.people_in_flat[client.name] = client
        print(f"Client {client.name} has been added")


    def bill(self):
        part = self.fees / len(self.people_in_flat.keys())

        for i in self.people_in_flat.values():
            days_in_flat = datetime(i.date.year, i.date.month+1, 1) - i.date
            c = (part * (days_in_flat.days-1)) / self.days_in_month
            print(f"{i.name} spent {days_in_flat.days-1} days, he has to pay: {c}")


    def to_pdf(self,filename="Billfile"):
        pass


class CreatePDFReport:
    def __init__(self, filename):
        self.filename = filename

    def to_pdf(self, flatmate):
        pass

flat = Flat()

med = Client("med", 1234)
zim = Client("zim", 5678)
zue = Client("zue", 9874)
zim.update_info(name="zim",phone="1234",date="2022 06 15")

flat.add_person(med)
flat.add_person(zim)
flat.add_person(zue)
flat.bill()