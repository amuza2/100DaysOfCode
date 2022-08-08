from docxtpl import DocxTemplate
import datetime


def create_invoice(info):
	today_date = datetime.date.today()
	doc = DocxTemplate("invoice.docx")
	context = {
			"date": today_date,
			"name": info["client_name"],
			"vendor": info["vendor_name"],
			"price": info["amount"],
			"quantity": info["quantity"],
			"delivery": today_date + datetime.timedelta(days=7)
			}
	doc.render(context)
	doc.save("filename.docx")

