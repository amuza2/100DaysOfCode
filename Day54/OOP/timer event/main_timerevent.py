from pygame.locals import *
import pygame
import pygwidgets
import sys
from timer_event import *

BLACK = (0,0,0)
WHITE = (255,255,255)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 400
FRAME_PER_SECOND = 30

pygame.init()
clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

start_button = pygwidgets.TextButton(window, loc=(230,300), text="Start")
label_1 = pygwidgets.DisplayText(window, loc=(230, 200), value="timer running")

label_1.hide()
oTimer_event = TimerEvent()

while True:
	for event in pygame.event.get():
		if event.type == QUIT:
			pygame.quit()
			sys.exit()

		if start_button.handleEvent(event):
			oTimer_event.start_timer()
			start_button.disable()
			label_1.show()

		if event.type == oTimer_event.timer_event_id():
			start_button.enable()
			label_1.hide()

	window.fill(BLACK)
	start_button.draw()
	label_1.draw()

	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)
