
class Employee():

	def __init__(self, name, title, ratePerHour=None):
		self.name = name
		self.title = title
		if ratePerHour is not None:
			ratePerHour = float(ratePerHour)
		self.ratePerHour = ratePerHour

	def get_Name(self):
		return self.name

	def get_title(self):
		return self.title

	def pay_per_year(self):
		pay = 52 * 5 * 8 * self.ratePerHour
		return pay



class Manager(Employee):

	def __init__(self, name, title, salary, reportsList=None):
		self.salary = float(salary)
		if reportsList is None:
			reportsList = []
		self.reportsList = reportsList
		super().__init__(name, title)

	def get_reports(self):
		return self.reportsList

	def pay_per_year(self, giveBunus = False):
		pay = self.salary
		if giveBunus:
			pay += (0.1 * self.salary)
			print(self.name, "gets a bonus for good work")
		return pay

	