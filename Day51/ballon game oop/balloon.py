import pygame
from pygame.locals import *
from constants import *
import random
import pygwidgets
from abc import ABC, abstractmethod

class Balloon():
	popSoundLoaded = False
	popSound = None

	@abstractmethod
	def __init__(self, window, maxWidth, maxHeight, oImage, ID, size,nPoints, speedy):
		self.wondow = window
		self.maxWidth = maxWidth
		self.maxHeight = maxHeight
		self.balloonImage = oImage
		self.ID = ID
		self.size = size
		self.nPoints = nPoints
		self.speedy = speedy

		if not Balloon.popSoundLoaded:
			Balloon.popSoundLoaded = True
			Balloon.popSound = pygame.mixer.Sound("sounds/balloonpop.wav")

		balloonRect = self.balloonImage.getRect()
		self.width = balloonRect.width
		self.height = balloonRect.height
		self.x = random.randrange(self.maxWidth - self.width)
		self.y = self.maxHeight + random.randrange(75)
		self.balloonImage.setLoc((self.x, self.y))

	def clickedInside(self, mousePoint):
		myRect = pygame.Rect(self.x, self.y, self.width, self.height)
		if myRect.collidepoint(mousePoint):
			Balloon.popSound.play()
			return True, self.nPoints
		else:
			return False, 0

	def update(self):
		self.y -= self.speedy
		self.balloonImage.setLoc((self.x, self.y))
		if self.y < -self.height:
			return BALLOON_MISSED
		else:
			return BALLOON_MOVING

	def draw(self):
		self.balloonImage.draw()

	def __def__(self):
		print(self.size, "balloon", self.ID, "is going away.")


class BalloonSmall(Balloon):
	smallBallon = random.choice(["redBalloon.png","greenBalloon.png","blueBalloon.png","orangeBalloon.png","pinkBalloon.png","purpleBalloon.png"])
	balloonImage = pygame.image.load(f"images/{smallBallon}")
	def __init__(self, window, maxWidth, maxHeight, ID):
		oImage = pygwidgets.Image(window, (0,0), BalloonSmall.balloonImage)
		super().__init__(window, maxWidth, maxHeight, oImage, ID, "Small", 30, 3.1)

class BalloonMedium(Balloon):
	balloonImage = pygame.image.load("images/redBalloonMedium.png")
	def __init__(self, window, maxWidth, maxHeight, ID):
		oImage = pygwidgets.Image(window, (0,0), BalloonMedium.balloonImage)
		super().__init__(window, maxWidth, maxHeight, oImage, ID, "Medium", 20, 2.5)

class BalloonLarge(Balloon):
	balloonImage = pygame.image.load("images/redBalloonLarge.png")
	def __init__(self, window, maxWidth, maxHeight, ID):
		oImage = pygwidgets.Image(window, (0,0), BalloonLarge.balloonImage)
		super().__init__(window, maxWidth, maxHeight, oImage, ID, "Large", 10, 1.5)