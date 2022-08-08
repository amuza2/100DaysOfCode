from docxtpl import DocxTemplate
import os, csv

with open("cars.csv") as f:
	data = csv.reader(f)
	data.__next__()
	counter = 1
	for i in data:
		doc = DocxTemplate("cars_info.docx")
		context = {
				"date": i[0],
				"name": i[1],
				"price": i[2],
				"gas_consumption": i[3],
				"miles": i[4],
				}
		doc.render(context)
		if not os.path.isdir("cars"):
			os.mkdir("cars")
		doc.save(f"cars/cars_details{counter}.docx")
		counter+=1