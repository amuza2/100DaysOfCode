from flask.views import MethodView
from wtforms import Form, StringField, SubmitField
from flask import Flask, render_template, request

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
		amount = billform.amount.data
		return amount


class BillForm(Form):
	
	amount = StringField("Bill Amount: ")
	period = StringField("Bill Period: ")
	name_1 = StringField("Name: ")
	days_in_house_1 = StringField("Days in the house: ")
	name_2 = StringField("Name: ")
	days_in_house_2 = StringField("Days in the house: ")

	button = SubmitField("Calculate")


app.add_url_rule('/', view_func=HomePage.as_view("home_page"))
app.add_url_rule("/bill",view_func=BillFormPage.as_view("bill_form_page"))
app.add_url_rule("/results", view_func=ResultPage.as_view("results_page"))
if "__main__" == __name__:
	app.jinja_env.auto_reload = True
	app.config['TEMPLATES_AUTO_RELOAD'] = True
	app.run(debug=True, host='0.0.0.0')