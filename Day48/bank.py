from account import *

class Blank:

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
		userAccountNumber = createAccount(userName,userStartingAmount,userPassword)
		print("Your new account number is", userAccountNumber)
		print()

	def closeAccount(self):
		print("*** Close Account ***")
		userAccountNumber = int(input("Enter you user account number: "))
		userPassword = input("Enter you account password: ")
		userAccount = self.accountDict[userAccountNumber]