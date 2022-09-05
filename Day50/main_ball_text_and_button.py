import pygame
from pygame.locals import *
import sys
import random
from ball import *
from text import *
from button import *


BLACK = (0, 0, 0)
WHITE = (255, 255, 255)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECONDS = 30

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

oBall = Ball(window, WINDOW_WIDTH, WINDOW_HEIGHT)
oFrameCountLabel = SimpleText(window, (60, 20), "Programe has run through this many loop:", WHITE)
oFrameCountDisplay = SimpleText(window, (500, 20), '', WHITE)
oRestartButton = SimpleButton(window, (280, 60), "images/restartUp.png", "images/restartDown.png")
frameCounter = 0

while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()


		if oRestartButton.handleEvent(event):
			oBall = Ball(window, WINDOW_WIDTH, WINDOW_HEIGHT)
			frameCounter = 0


	oBall.update()
	frameCounter += 1
	oFrameCountDisplay.setValue(str(frameCounter//60))
	window.fill(BLACK)
	oBall.draw()
	oFrameCountLabel.draw()
	oFrameCountDisplay.draw()
	oRestartButton.draw()
	pygame.display.update()
	clock.tick(FRAME_PER_SECONDS)