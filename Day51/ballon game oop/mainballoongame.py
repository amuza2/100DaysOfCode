from balloonmanager import *
import pygame
from pygame.locals import *
import sys
import pygwidgets
from constants import *

BLACK = (0,0,0)
GRAY = (200,200,200)
BACKGROUND_COLOR = (0,180,180)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 640
PANEL_HEIGHT = 60
USABLE_WINDOW_HEIGHT = WINDOW_HEIGHT - PANEL_HEIGHT
FRAME_PER_SECONDS = 30

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

oScoreDisplay = pygwidgets.DisplayText(window, (10, USABLE_WINDOW_HEIGHT+20), "Score: 0", textColor=BLACK,backgroundColor=None,width=140,fontSize=24)
oStatusDisplay = pygwidgets.DisplayText(window, (180, USABLE_WINDOW_HEIGHT+20), '',textColor=BLACK,backgroundColor=None,width=300, fontSize=24)
oStartButton = pygwidgets.TextButton(window, (WINDOW_WIDTH-110, USABLE_WINDOW_HEIGHT+10), "Start")

oBalloonManager = BalloonManager(window, WINDOW_WIDTH, USABLE_WINDOW_HEIGHT)
playing = False

while True:
	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

		if playing:
			oBalloonManager.handleEvent(event)
			theScore = oBalloonManager.getScore()
			oScoreDisplay.setValue("Score: " + str(theScore))
		elif oStartButton.handleEvent(event):
			oBalloonManager.start()
			playing = True
			oStartButton.disable()

	if playing:
		oBalloonManager.update()
		nPopped = oBalloonManager.getCountPopped()
		nMissed = oBalloonManager.getCountMissed()
		oStatusDisplay.setValue("Popped: " + str(nPopped)\
								+ "   Missed: " + str(nMissed)\
								+ "   Out of: " + str(N_BALLOONS))

		if (nPopped + nMissed) == N_BALLOONS:
			playing = False
			oStartButton.enable()

	window.fill(BACKGROUND_COLOR)
	if playing:
		oBalloonManager.draw()

	pygame.draw.rect(window, GRAY, pygame.Rect(0,USABLE_WINDOW_HEIGHT, WINDOW_WIDTH, PANEL_HEIGHT))
	oScoreDisplay.draw()
	oStatusDisplay.draw()
	oStartButton.draw()

	pygame.display.update()
	clock.tick(FRAME_PER_SECONDS)