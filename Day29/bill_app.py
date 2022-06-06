"""
create an app that calculate the amount of any person
stayes in a house accourding on the days he/she stayed.

names: amount, person, house, days
30 days ==> 30 dollars
15 days ==> x
x = (15 * 30)/ 30
"""
from flat import Client, Flat
from pdfExpoter import CreatePDFReport

c_1_name = input("Enter you name: ")
c_1_identity = int(input("Enter you identity number: "))

c_2_name = input("Enter you name: ")
c_2_identity = int(input("Enter you identity number: "))
c_2_update_info = input("enter updated date: ")


flat = Flat()

med = Client(c_1_name, c_1_identity)
zim = Client(c_2_name, c_2_identity)
zim.update_info(name="mounir",phone="1234",date=c_2_update_info)
flat.add_person(med)
flat.add_person(zim)
flat.bill()


export = CreatePDFReport("invoice")
export.to_pdf(flat)