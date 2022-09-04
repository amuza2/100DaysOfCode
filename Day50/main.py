from button import *
import pygame
from pygame.locals import *
import sys


BLACK = (0,0,0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECONDS = 30

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

buttonUp= "images/buttonUp.png"
buttonDown = "images/buttonDown.png"
oButton = SimpleButton(window, (150,30), buttonUp, buttonDown)

while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

	oButton.handleEvent(event)
	window.fill(BLACK)
	oButton.draw()
	pygame.display.update()
	clock.tick(FRAME_PER_SECONDS)