import pygame
from pygame.locals import *
import sys
import pygwidgets
from inputnumber import *
from displaymoney import *

BLACK = (0,0,0)
BLACKISH = (10,10,10)
GRAY = (128,128,128)
WHITE = (255,255,255)
BACKGROUND_COLOR = (0,180,180)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30

pygame.init()
window = pygame.display.set_mode([WINDOW_WIDTH, WINDOW_HEIGHT])
clock = pygame.time.Clock()


title = pygwidgets.DisplayText(window,(0,40),
		"Demo of InputNumber and DisplayMoney fields",
		fontSize=36,width=WINDOW_WIDTH, justified="center")
inputCaption = pygwidgets.DisplayText(window,(20,150),
				"Input money amount: ",fontSize=24,width=190,
				justified="right")
inputField = InputNumber(window, (230,150),'',width=150)
okButton = pygwidgets.TextButton(window, (430,150), "Ok")
outputCaption1 = pygwidgets.DisplayText(window,(20,300),
				"Output dollar & cents: ",fontSize=24,width=190,
				justified="right")
moneyField1 = DisplayMoney(window, (230,300),'',textColor=BLACK,
			backgroundColor=WHITE,width=150)
outputCaption2 = pygwidgets.DisplayText(window,(20,400),
				"Output dollars only: ", fontSize=24,width=190,
				justified="right")
moneyField2 = DisplayMoney(window, (230,400),'',textColor=BLACK,
			backgroundColor=WHITE,width=150,showCents=False)

while True:
	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

		if inputField.handleEvent(event) or okButton.handleEvent(event):
			try:
				theValue = inputField.getValue()
			except ValueError:
				inputField.setValue("(not a number)")
			else:
				theText = str(theValue)
				moneyField1.setValue(theText)
				moneyField2.setValue(theText)

	window.fill(BACKGROUND_COLOR)
	title.draw()
	inputCaption.draw()
	inputField.draw()
	okButton.draw()
	outputCaption1.draw()
	outputCaption2.draw()
	moneyField1.draw()
	moneyField2.draw()
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)
