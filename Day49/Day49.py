import pygame
from pygame.locals import *
import sys
import random

#screen
BLACK = (0, 0, 0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30
N_PIXELS_PER_FRAME = 7
BALL_WIDTH_HEIGHT = 100

#ball
MAX_WIDTH = WINDOW_WIDTH - BALL_WIDTH_HEIGHT
MAX_HEIGHT = WINDOW_HEIGHT - BALL_WIDTH_HEIGHT

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
clock = pygame.time.Clock()

#load images
ballImage = pygame.image.load("images/ball.png")

#ball position
ballX = random.randrange(MAX_WIDTH)
ballY = random.randrange(MAX_HEIGHT)
xSpeed = N_PIXELS_PER_FRAME
ySpeed = N_PIXELS_PER_FRAME
random.seed(3)
while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

	if (ballX<0) or (ballX>=MAX_WIDTH):
		xSpeed = -xSpeed
	if (ballY<0) or (ballY>=MAX_HEIGHT):
		ySpeed = -ySpeed

	ballX += xSpeed
	ballY += ySpeed
		

	window.fill(BLACK)
	window.blit(ballImage, (ballX,ballY))
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)

