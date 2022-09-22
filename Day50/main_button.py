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

buttonAUp= "images/buttonAUp.png"
buttonADown = "images/buttonADown.png"
buttonBUp= "images/buttonBUp.png"
buttonBDown = "images/buttonBDown.png"
buttonCUp= "images/buttonCUp.png"
buttonCDown = "images/buttonCDown.png"

class CallbackTest():
	def myMethod(self):
		print("User pressed Button C, Called myMethod")
oCallbacktest = CallbackTest()

oButtonA = SimpleButton(window, (25,30), buttonAUp, buttonADown)
oButtonB = SimpleButton(window, (150,30), buttonBUp, buttonBDown)
oButtonC = SimpleButton(window, (275,30), buttonCUp, buttonCDown,callback=oCallbacktest.myMethod)

while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

		if oButtonA.handleEvent(event):
			print("You pressed button A")
		elif oButtonB.handleEvent(event):
			print("You pressed button B")
		elif oButtonC.handleEvent(event):
			print("You pressed button C")

	window.fill(BLACK)

	oButtonA.draw()
	oButtonB.draw()
	oButtonC.draw()
	
	pygame.display.update()
	clock.tick(FRAME_PER_SECONDS)