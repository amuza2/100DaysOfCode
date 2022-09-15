
import pygame
import pygwidgets


class Card():
	BACK_OF_IMAGE = pygame.image.load("images/BackOfCard.png")

	def __init__(self, window, rank, suit, value):
		self.window = window
		self.rank = rank
		self.suit = suit
		self.value = value
		self.cardName = rank + " of " + suit

		fileName = "images/" + self.cardName + ".png"