import pygame
from pygame.locals import *
import random


class Ball():

	def __init__(self, window, windowWidth, windowHeight):
		self.window = window
		self.windowWidth = windowWidth
		self.windowHeight = windowHeight
		self.image = pygame.image.load("images/ball.png")
		ballRect = self.image.get_rect()
		self.width = ballRect.width
		self.height = ballRect.height
		self.maxWidth = self.windowWidth - self.width
		self.max_height = self.windowHeight - self.height
		self.x = random.randrange(self.maxWidth)
		self.y = random.randrange(self.max_height)
		speedsList = [-5,-4,-3,3,4,5]
		self.xspeed = random.choice(speedsList)
		self.yspeed = random.choice(speedsList)

	def update(self):
		if (self.x<0) or (self.x>self.maxWidth):
			self.xspeed = - self.xspeed
		if (self.y<0) or (self.y>=self.max_height):
			self.yspeed = - self.yspeed

		self.x += self.xspeed
		self.y += self.yspeed

	def draw(self):
		self.window.blit(self.image, (self.x,self.y))