
import random
from card import *


class Deck():
	SUIT_TUPLE = ("Diamonds", "Clubs", "Hearts", "Spades")
	STANDARD_DICT = {"Ace":1,'2':2,'3':3,'4':4,'5':5,'6':6,'7':7,'8':8,'9':9,'10':10,"Jack":11,"Queen":12,"King":13}

	def __init__(self, window, rankValueDick=STANDARD_DICT):
		self.startingDeckList = []
		self.playingDeckList = []
		for suit in Deck.SUIT_TUPLE:
			for rank, value in rankValueDick.items():
				oCard = Card(window, rank, suit, value)
				self.startingDeckList.append(oCard)

			self.shuffle()

	def shuffle(self):
		self.playingDeckList = self.startingDeckList.copy()
		for oCard in self.playingDeckList:
			oCard.conceal()
		random.shuffle(self.playingDeckList)

	def getCard(self):
		if len(self.playingDeckList) == 0:
			raise IndexError("No more Cards")
		oCard = self.playingDeckList.pop()
		return oCard

	def returnCardToDeck(self, oCard):
		self.playingDeckList.insert(0, oCard)


if __name__ == "__main__":
	import pygame

	WINDOW_WIDTH = 100
	WINDOW_HEIGHT = 100

	pygame.init()
	window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
	oDeck = Deck(window)
	for i in range(1, 53):
		oCard = oDeck.getCard()
		print("Name: ", oCard.getName(), "   Value:",oCard.getValue())