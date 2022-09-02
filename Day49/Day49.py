import pygame
from pygame.locals import *
import sys
import random


BLACK = (0, 0, 0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30

#ball
BALL_WIDTH_HEIGHT = 100
MAX_WIDTH = WINDOW_WIDTH - BALL_WIDTH_HEIGHT
MAX_HEIGHT = WINDOW_HEIGHT - BALL_WIDTH_HEIGHT

#target
TARGET_X = 400
TARGET_Y = 320
TARGET_WIDTH_HEIGHT = 120
N_PIXELS_TO_MOVE = 3

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
clock = pygame.time.Clock()

#load images
ballImage = pygame.image.load("images/ball.png")
targetImage = pygame.image.load("images/target.jpg")

#ball position
ballX = random.randrange(MAX_WIDTH)
ballY = random.randrange(MAX_HEIGHT)
# ballRect = pygame.Rect(ballX, ballY, BALL_WIDTH_HEIGHT, BALL_WIDTH_HEIGHT)
# target position
targetRect = pygame.Rect(TARGET_X, TARGET_Y, TARGET_WIDTH_HEIGHT, TARGET_WIDTH_HEIGHT) 

while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

		elif event.type == pygame.KEYDOWN:
			if event.key == pygame.K_LEFT:
				ballX -= N_PIXELS_TO_MOVE
			elif event.key == pygame.K_RIGHT:
				ballX += N_PIXELS_TO_MOVE
			elif event.key == pygame.K_UP:
				ballY -= N_PIXELS_TO_MOVE
			elif event.key == pygame.K_DOWN:
				ballY += N_PIXELS_TO_MOVE
	ballRect = pygame.Rect(ballX, ballY, BALL_WIDTH_HEIGHT, BALL_WIDTH_HEIGHT)
	if ballRect.colliderect(targetRect):
		print("Ball is touching the target")

		# if event.type == pygame.MOUSEBUTTONUP:
		# 	mouseX, mouseY = event.pos
		# 	if ballRect.collidepoint(event.pos):
		# 		ballX = random.randrange(MAX_WIDTH)
		# 		ballY = random.randrange(MAX_HEIGHT)
		# 		ballRect = pygame.Rect(ballX, ballY, BALL_WIDTH_HEIGHT, BALL_WIDTH_HEIGHT)


	window.fill(BLACK)
	window.blit(targetImage, (TARGET_X,TARGET_Y))
	window.blit(ballImage, (ballX,ballY))
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)

