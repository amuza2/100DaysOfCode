class AbordTransaction(Exception):
	""" raise this exception to abord bank transaction"""
	pass

class Account:

	def __init__(self, name, balance, password):
		self.name = name
		self.balance = self.validateAmount(balance)
		self.password = password


	def validateAmount(self, amount):
		try:
			amount = int(amount)
		except ValueError:
			raise AbordTransaction("Amount must be an integer")
		if amount <= 0:
			raise AbordTransaction("amount must be positive")


	def checkPasswordMatch(self, password):
		if password != self.password:
			raise AbordTransaction("Incorrect Password!")

	def deposit(self,amountToDeposit):
		amountToDeposit = self.validateAmount(amountToDeposit)
		self.balance += amountToDeposit
		return self.balance

	
	def withdraw(self, amountToWithdraw):
		amountToWithdraw = self.validateAmount(amountToWithdraw)
		if amountToWithdraw > self.balace:
			raise AbordTransaction("You can't withdraw more then you have in your account")
		self.balance -= amountToWithdraw
		return self.balance


	def getBalance(self):
		return self.balance


	def show(self):
		print("      Name:", self.name)
		print("      Balance:", self.balance)
		print("      Password:", self.password)
		print()

		