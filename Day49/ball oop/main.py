import pygame
from pygame.locals import *
import sys
import random
from ball import *
import os
os.chdir(r'C:\Users\REALMAN\Desktop\psill\youtubework\100DaysOfCode\Day49\ball oop')


BLACK = (0,0,0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECONDS = 30
N_BALL = 3

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

ballList = []
for oBall in range(N_BALL):
	oBall = Ball(window, WINDOW_WIDTH, WINDOW_HEIGHT)
	ballList.append(oBall)

while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

	for oBall in ballList:
		oBall.update()

	window.fill(BLACK)
	for oBall in ballList:
		oBall.draw()
	pygame.display.update()
	clock.tick(FRAME_PER_SECONDS)