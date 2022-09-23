import pygame
from pygame.locals import *
from elapsed_time import *
import sys
import pygwidgets

BLACK = (0,0,0)
WHITE = (255, 255, 255)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 400
FRAME_PER_SECOND = 30

pygame.init()
clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

start_button = pygwidgets.TextButton(window, loc=(200,300), text="Start")
label_1 = pygwidgets.DisplayText(window, loc=(200, 200),value="Time running",textColor=WHITE,fontSize=24)

label_1.hide()
oTimer = ElapsedTime()

while True:
	for event in pygame.event.get():
		if event.type == QUIT:
			pygame.quit()
			sys.exit()

		if start_button.handleEvent(event):
			start_button.disable()
			label_1.show()
			print("Starting timer")
			oTimer.start_time()
	
	if oTimer.action_time:
		oTimer.update()
		print("if it works")
		if oTimer.check_time():
			start_button.enable()
			label_1.hide()
			print("end")


	window.fill(BLACK)
	start_button.draw()
	label_1.draw()

	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)