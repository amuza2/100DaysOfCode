"""
create an app that calculate the amount of any person
stayes in a house accourding on the days he/she stayed.

names: amount, person, house, days
30 days ==> 30 dollars
15 days ==> x
x = (15 * 30)/ 30
"""

import fpdf
from datetime import datetime

class Client:
    def __init__(self, name):
        self.name = name
        self.day = datetime.


class Flat:
    monthly_fee = 120
    people = []
    after_calc = []


    def __init__(self,client,days):
        self.

    def pays(self):
        split = self.monthly_fee / len(self.people) 
        for person in self.people:
            payment = (person[1] * split)/30
            self.after_calc.append([person[0], payment])


    def add_person(self, name, days):
        self.people.append([name,days])


    def show_result(self):
        self.pays()
        for i in self.after_calc:
            print(f"{i[0]} pays {i[1]}")

    def to_pdf(self,filename="Billfile"):
        pass


class CreatePDFReport:
    def __init__(self, filename):
        self.filename = filename

    def to_pdf(self, flatmate)

