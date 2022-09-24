import pygame
from pygame.locals import *
from timer import Timer
import pygwidgets
import sys


WHITE = (255,255,255)
BLACK = (0,0,0)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 400
FRAME_PER_SECOND = 30

pygame.init()
clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

start_button = pygwidgets.TextButton(window, loc=(250,200), text="Start")
stop_button = pygwidgets.TextButton(window, loc=(140,200), text="Stop")
label_2 = pygwidgets.DisplayText(window,loc=(240, 150), value='0',fontSize=24,textColor=WHITE)
label_1 = pygwidgets.DisplayText(window,loc=(180, 250), value="timer is running",fontSize=24,textColor=WHITE)


label_1.hide()
stop_button.disable()
oTimer = Timer(2.5)

while True:
	for event in pygame.event.get():
		if event.type == QUIT:
			pygame.quit()
			sys.exit()

		if start_button.handleEvent(event):
			start_button.disable()
			stop_button.enable()
			label_1.show()
			oTimer.start()


		if stop_button.handleEvent(event):
			oTimer.stop_timer()
			label_2.setValue(round(oTimer.get_time(),1))
			label_1.hide()
			start_button.enable()
			stop_button.disable()

	
	label_2.setValue(round(oTimer.get_time(),1))

	if oTimer.update():
		label_1.hide()
		start_button.enable()
		stop_button.disable()


	window.fill(BLACK)
	start_button.draw()
	stop_button.draw()
	label_1.draw()
	label_2.draw()
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)