from flask.views import MethodView
from wtforms import Form, StringField, SubmitField
from flask import Flask, render_template, request
import flat


app = Flask(__name__)

class HomePage(MethodView):

	def get(self):
		return render_template("index.html")


class BillFormPage(MethodView):

	def get(self):
		bill_form = BillForm()
		return render_template("bill_form_page.htm", billform=bill_form)


class ResultPage(MethodView):
	
	def post(self):
		billform = BillForm(request.form)
		amount = float(billform.amount.data)
		period = billform.period.data
		flatmate_1_name = billform.name_1.data
		flatmate_1_days = float(billform.days_in_house_1.data)
		flatmate_2_name = billform.name_2.data
		flatmate_2_days = float(billform.days_in_house_2.data)
		
		the_bill = flat.Bill(amount, period)
		flatmate_1 = flat.Flatmate(flatmate_1_name, flatmate_1_days)
		flatmate_2 = flat.Flatmate(flatmate_2_name, flatmate_2_days)
		return render_template("results.html", name_1=flatmate_1_name,amount_to_pay_1=round(flatmate_1.pays(the_bill, flatmate_2),0),
												name_2=flatmate_2_name,amount_to_pay_2=round(flatmate_2.pays(the_bill, flatmate_1),0))


class BillForm(Form):
	
	amount = StringField("Bill Amount: ", default=100)
	period = StringField("Bill Period: ",default="December 2022")
	name_1 = StringField("Name: ", default="Moh")
	days_in_house_1 = StringField("Days in the house: ",default=15)
	name_2 = StringField("Name: ",default="Amine")
	days_in_house_2 = StringField("Days in the house: ",default=20)

	button = SubmitField("Calculate")


app.add_url_rule('/', view_func=HomePage.as_view("home_page"))
app.add_url_rule("/bill",view_func=BillFormPage.as_view("bill_form_page"))
app.add_url_rule("/results", view_func=ResultPage.as_view("results_page"))
if "__main__" == __name__:
	app.jinja_env.auto_reload = True
	app.config['TEMPLATES_AUTO_RELOAD'] = True
	app.run(debug=True,host="0.0.0.0", port="5500")