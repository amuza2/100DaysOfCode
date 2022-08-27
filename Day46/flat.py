class Bill:
	"""
	Object contain data about a bill, such as
	total amount and period of the bill

	"""

	def __init__(self, amount, period):
		self.amount = amount
		self.period = period


class Flatmate:
	"""
	Creating flatmate customer who lives in the flat
	and pays his share of the bill
	"""

	def __init__(self, name, days_in_house):
		self.name = name
		self.days_in_house = days_in_house

	def pays(self, bill, flatmate):
		part = self.days_in_house / (self.days_in_house + flatmate.days_in_house)
		part_to_pay = bill.amount * part 
		return part_to_pay