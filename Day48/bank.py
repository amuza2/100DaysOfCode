from account import *

class Bank:

	def __init__(self):
		self.accountDict = {}
		self.nextAccountNumber = 0

	def createAccount(self, theName, theStartingAmount,ThePassword):
		oAccount = Account(theName, theStartingAmount, ThePassword)
		newAccountNumber = self.nextAccountNumber
		self.accountDict[newAccountNumber] = oAccount
		self.nextAccountNumber += 1
		return newAccountNumber

	def openAccount(self):
		print("*** Open Account ***")
		userName = input("Enter your name for the new user account: ")
		userStartingAmount = int(input("Enter the starting balance for your account: "))
		userPassword = input("Enter your password for your account: ")
		userAccountNumber = self.createAccount(userName,userStartingAmount,userPassword)
		print("Your new account number is", userAccountNumber)
		print()

	def closeAccount(self):
		print("*** Close Account ***")
		userAccountNumber = int(input("Enter you user account number: "))
		userPassword = input("Enter you account password: ")
		oUserAccount = self.accountDict[userAccountNumber]
		userBalance = oUserAccount.getBalance(userPassword)
		if userBalance is not None:
			print(f"you have {userBalance} to withdraw before colsing your account")
		del self.accountDict[userAccountNumber]
		print("Your account is now closed")
		print()

	def balance(self):
		print("*** show balance ***")
		userAccountNumber = int(input("Enter you user account number: "))
		userPassword = input("Enter your account password: ")
		oUserAccount = self.accountDict[userAccountNumber]
		userBalance = oUserAccount.getBalance(userPassword)
		print("Your Balance account is", userBalance)
		print()

	def deposit(self):
		print("*** Desposit ***")
		userAccountNumber = int(input("Enter your user account number: "))
		userDepositAmount = int(input("Enter your amount to deposit to your account: "))
		userPassword = input("Enter your account password: ")
		oUserAccount = self.accountDict[userAccountNumber]
		userBalance = oUserAccount.deposit(userDepositAmount, userPassword)
		if userBalance is not None:
			print("Your balance account is now:", userBalance)
		print()

	def showInfo(self):
		print("*** Show bank account details ***")
		for userAccountNumber in self.accountDict:
			oAccount = self.accountDict[userAccountNumber]
			print("user account number:", userAccountNumber)
			oAccount.show()
		print()

	def withdraw(self):
		print("*** withdraw ***")
		userAccountNumber = int(input("Enter your user account number: "))
		userAmountWithdraw = int(input("Enter the amount to withdraw: "))
		userPassword = input("Enter user account password: ")
		oUserAccount = self.accountDict[userAccountNumber]
		userbalance = oUserAccount.withdraw(userAmountWithdraw, userPassword)
		if userBalance is not None:
			print("Your account balance now is", userBalance)


