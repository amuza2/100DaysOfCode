import pygame
import random

RED = (255,0, 0)
GREEN = (0, 255, 0)
BLUE = (0, 0, 255)

class square():
	
	def __init__(self, window, maxWidth, maxHeight):
		self.window = window
		self.widthAndHeight = random.randrange(10, 100)
		self.color = random.choice((RED, GREEN, BLUE))
		self.x = random.randrange(1, maxWidth - 100)
		self.y = random.randrange(25, maxHeight - 100)
		self.rect = pygame.Rect(self.x, self.y, self.widthAndHeight,self.widthAndHeight)
		self.shapeType = "Square"

	
	def clickedinside(self, mousePoint):
		clicked = self.rect.collidepoint(mousePoint)
		return clicked

	
	def getType(self):
		return self.shapeType


	def getArea(self):
		theArea = self.widthAndHeight * self.widthAndHeight
		return theArea

	
	def draw(self):
		pygame.draw.rect(self.window, self.color, self.x, self.y, self.widthAndHeight, self.widthAndHeight)

