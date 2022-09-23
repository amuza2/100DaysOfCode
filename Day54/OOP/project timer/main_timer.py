from counting_frames import *
import pygwidgets
import pygame
from pygame.locals import *
import sys

BLACK = (55,55,100)
GREY = (200,200,200)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 300
FRAME_PER_SECOND = 30

pygame.init()
clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

label_1 = pygwidgets.DisplayText(window, loc=(200,100),value="Timer running",fontSize=24,textColor=GREY,justified="left")
start_button = pygwidgets.TextButton(window, loc=(200,150), text="Start")
click_me = pygwidgets.TextButton(window, loc=(80,150), text="click me")
label_2 = pygwidgets.DisplayText(window, loc=(230,200),value="0",fontSize=24,textColor=GREY,justified="center")
oCounter = CountingFrames()

label_1.hide()
while True:
	for event in pygame.event.get():
		if event.type == QUIT:
			pygame.quit()
			sys.exit()

		if start_button.handleEvent(event):
			oCounter.active_counting()
			start_button.disable()
			label_1.show()

		if click_me.handleEvent(event):
			print("Click on me")

	label_2.setValue(int(oCounter.counter()))
	if oCounter.update():
		start_button.enable()
		label_1.hide()

	window.fill(BLACK)
	label_1.draw()
	label_2.draw()
	start_button.draw()
	click_me.draw()
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)