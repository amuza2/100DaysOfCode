
class Account:

	def __init__(self,name, balance, password):
		self.name = name
		self.balance = int(balance)
		self.password = password

	def deposit(self,amountToDeposit, password):
		if password != self.password:
			print("Sorry incorrect password")
			return None
		if amountToDeposit < 0:
			print("You can't deposit a negative amount")
			return None
		self.balance += amountToDeposit
		return self.balance

	
	def withdraw(self, amountToWithdraw, password):
		if password != self.password:
			print("Sorry incorrect password")
			return None
		if amountToWithdraw < 0:
			print("You can't withdraw a negative amount")
			return None
		if amountToWithdraw > self.balace:
			print("You can't withdraw more then you have in your account")
			return None
		self.balance += amountToWithdraw

	def getBalance(self, password):
		if password != self.password:
			print("Sorry incorrect password")
			return None
		return self.balance
	def show(self):
		print("      Name:", self.name)
		print("      Balance:", self.balance)
		print("      Password:", self.password)
		print()

		