import pygwidgets
from deck import *
from card import *
from constants import *
import pygame


class Game():
	CARD_OFFSET = 110
	CARD_TOP = 300
	CARD_LEFT = 75
	NCARDS = 8
	POINTS_CORRECT = 15
	POINTS_INCORRECT = 10

	def __init__(self, window):
		self.window = window
		self.oDeck = Deck(self.window)
		self.score = 100
		self.scoreText = pygwidgets.DisplayText(window,(450,164),"Score: "+str(self.score),fontSize=36,textColor=WHITE,justified='right')
		self.messageText = pygwidgets.DisplayText(window,(50,460),width=900,justified='center',fontSize=36,textColor=WHITE)
		self.loserSound = pygame.mixer.Sound("sounds/loser.wav")
		self.winnerSound = pygame.mixer.Sound("sounds/ding.wav")
		self.cardShuffleSound = pygame.mixer.Sound("sounds/cardShuffle.wav")
		self.cardXPositionsList = []
		thisLeft = Game.CARD_LEFT
		for cardNum in range(Game.NCARDS):
			self.cardXPositionsList.append(thisLeft)
			thisLeft += Game.CARD_OFFSET

		self.reset()

	def reset(self):
		self.cardShuffleSound.play()
		self.cardList = []
		self.oDeck.shuffle()
		for cardIndex in range(Game.NCARDS):
			oCard = self.oDeck.getCard()
			self.cardList.append(oCard)
			thisXPosition = self.cardXPositionsList[cardIndex]
			oCard.setLoc((thisXPosition, Game.CARD_TOP))
			self.showCard(0)
			self.cardNumber = 0
			self.currentCardName, self.currentCardValue = \
				self.getCardNameAndValue(self.cardNumber)
			self.messageText.setValue("Starting card is " + self.currentCardName + ". Will the next card be higher or lower?")

	def getCardNameAndValue(self, index):
		oCard = self.cardList[index]
		theName = oCard.getName()
		theValue = oCard.getValue()
		return theName, theValue

	def showCard(self, index):
		oCard = self.cardList[index]
		oCard.reveal()

	def hitHigherOrLower(self, higherOrLower):
		self.cardNumber += 1
		self.showCard(self.cardNumber)
		nextCardName, nextCardValue = self.getCardNameAndValue(self.cardNumber)
		if higherOrLower == HIGHER:
			if nextCardValue > self.currentCardValue:
				self.score += Game.POINTS_CORRECT
				self.messageText.setValue("Yes, the "+nextCardName+" was higher")
				self.winnerSound.play()
			else:
				self.score -= Game.POINTS_INCORRECT
				self.messageText.setValue("No, the "+ nextCardName+ " was not higher")
				self.loserSound.play() 
		else:
			if nextCardValue < self.currentCardValue:
				self.score += Game.POINTS_CORRECT
				self.messageText.setValue("Yes, the "+nextCardName+" was higher")
				self.winnerSound.play()
			else:
				self.score -= Game.POINTS_INCORRECT
				self.messageText.setValue("No, the "+ nextCardName+ " was not higher")
				self.loserSound.play()
		self.scoreText.setValue("Score: " + str(self.score))
		self.currentCardValue = nextCardValue
		done = (self.cardNumber == (Game.NCARDS - 1))
		return done

	def draw(self):
		for oCard in self.cardList:
			oCard.draw()
			self.scoreText.draw()
			self.messageText.draw()	

					