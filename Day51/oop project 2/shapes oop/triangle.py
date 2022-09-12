import pygame
from shape import *


class Triangle(Shape):
	def __init__(self, window, maxWidth, maxHeight):
		super().__init__(window, "Triangle", maxWidth, maxHeight)
		self.width = random.randrange(10, 100)
		self.height = random.randrange(10, 100)
		self.triangleSlop = -1 * (self.height / self.width)
		self.rect = pygame.Rect(self.x, self.y, self.width, self.height)

	def clickedInside(self, mousePoint):
		inRect = self.rect.collidePoint(mousePoint)
		if not inRect:
			return False

		xOffset = mousePoint[0] - self.x
		yOffset = mousePoint[1] - self.y
		if xOffset == 0:
			return True

		pointSlopeFromYIntercept = (yOffset - self.height) / xOffset
		if pointSlopeFromYIntercept < 1:
			return True
		else:
			return False

	def getArea(self):
		theArea = 0.5 * self.width * self.height
		return theArea

	def draw(self):
		pygame.draw.polygon(self.window, self.color, (self.x,self.y + self.height),
			pygame									(self.x, self.y),
													(self.x + self.width, self.y))