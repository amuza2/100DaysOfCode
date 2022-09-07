
class Student():
	def __init__(self, name, grade = 0):
		self.name = name
		self._grade = grade

	@property
	def get_grade(self):
		return self._grade

	@get_grade.setter
	def set_grade(self, value):
		try:
			new_grade = int(value)
		except (TypeError, ValueError) as e:
			raise type(e)("New grade:" + str(value) + ", is invalid type.")
		self._grade = value


oStudent1 = Student("Mohammed")
print(oStudent1.get_grade)
oStudent1.set_grade = "twenty"
print(oStudent1.get_grade)
