from docxtpl import DocxTemplate
import os
import csv

with open("cars.csv") as f:
	data = csv.reader(f)
	data.__next__()
	counter = 1
	for column in data:
		doc = DocxTemplate("cars_info.docx")
		context = {
				"date": column[0],
				"name": column[1],
				"price": column[2],
				"gas_consumption": column[3],
				"miles": column[4],
				}
		doc.render(context)
		if not os.path.isdir("cars"):
			os.mkdir("cars")
		doc.save(f"cars/cars_details{counter}.docx")
		counter+=1
		