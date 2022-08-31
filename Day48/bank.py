from account import *

class Bank:

	def __init__(self, hours, address, phone):
		self.accountDict = {}
		self.nextAccountNumber = 0
		self.hours = hours
		self.address = address
		self.phone = phone


	def askForValidAccountNumber(self):
		userAccountNumber = input("Enter your user account number: ")
		try:
			userAccountNumber = int(userAccountNumber)
		except ValueError:
			raise AbordTransaction("The account number must be an integer.")
		if userAccountNumber not in self.accountDict:
			raise AbordTransaction("There is not account " + str(userAccountNumber))
		return userAccountNumber

	def askForValidPassword(self, oUserAccount):
		userPassword = input("Enter you account password: ")
		if userPassword != oUserAccount.password:
			raise AbordTransaction("Your password is incorrect")


	def getUserAccount(self):
		userAccountNumber = self.askForValidAccountNumber()
		oAccount = self.accountDict[userAccountNumber]
		self.askForValidPassword(oAccount)
		return oAccount

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
		oUserAccount = self.getUserAccount() 
		userDepositAmount = input("Enter your amount to deposit to your account: ")
		userBalance = oUserAccount.deposit(userDepositAmount)
		print("You Diposited:", userDepositAmount)
		print("Your new balance is", str(userBalance))
		print()


	def withdraw(self):
		print("*** withdraw ***")
		oUserAccount = self.accountDict[userAccountNumber]
		userAmountWithdraw = input("Enter the amount to withdraw: ")
		userBalance = oUserAccount.withdraw(userAmountWithdraw)
		print("You withdraw:", userAmountWithdraw)
		print("Your new balance is" ,str(userBalance))
		print()

	def getInfo(self):
		print("Hours:     ", self.hourse)
		print("Address:   ", self.address)
		print("Phone:     ", self.phone)
		print("We currently have", len(self.accountDict),"account(s) open.")

	def showInfo(self):
		print("*** Show bank account details ***")
		for userAccountNumber in self.accountDict:
			oAccount = self.accountDict[userAccountNumber]
			print("user account number:", userAccountNumber)
			oAccount.show()
		print()
