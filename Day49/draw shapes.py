import pygame
from pygame.locals import *
import sys

# Screen
BLACK = (0,0,0)
BLUE = (240,248,255)
GREEN = (50,205,50)
RED = (250,128,114)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30

# Initialize
pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
clock = pygame.time.Clock()


while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

	window.fill(BLACK)
	pygame.draw.line(window, BLUE, (20,20), (60,20),4)
	pygame.draw.line(window, BLUE, (20,20), (20,60),4)
	pygame.draw.line(window, BLUE, (20,60), (60,60),4)
	pygame.draw.line(window, BLUE, (60,20), (60,60),4)

	pygame.draw.line(window, BLUE, (20,20), (60,60),1)
	pygame.draw.line(window, BLUE, (20,60), (60,20),1)

	pygame.draw.circle(window, GREEN, (250, 50), 30,0)
	pygame.draw.circle(window, GREEN, (400, 50), 30,2)

	pygame.draw.rect(window, RED, (250, 150, 100, 50),0)
	pygame.draw.rect(window, RED, (400, 150, 100, 50),1)

	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)