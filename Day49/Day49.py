import pygame
from pygame.locals import *
import sys
import random

BLACK = (0, 0, 0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30

BALL_WIDTH_HEIGHT = 100
MAX_WIDTH = WINDOW_WIDTH - BALL_WIDTH_HEIGHT
MAX_HEIGHT = WINDOW_HEIGHT - BALL_WIDTH_HEIGHT

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
clock = pygame.time.Clock()

ballImage = pygame.image.load("images/ball.png")

ballX = rendom.randrange(MAX_WIDTH)
ballY = random.randrange(MAX_HEIGHT)


while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()


	window.blit(ballImage, (100,200))
	# window.fill(BLACK)
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)

