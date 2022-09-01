import pygame
from pygame.locals import *
import sys

BLACK = (0, 0, 0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
clock = pygame.time.Clock()


while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

	window.fill(BLACK)
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)

