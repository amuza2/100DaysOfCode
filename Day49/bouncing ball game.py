import pygame
from pygame.locals import *
import sys
import random

#screen
BLACK = (0, 0, 0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECOND = 30
N_PIXELS_PER_FRAME = 7
BALL_WIDTH_HEIGHT = 100

#ball
MAX_WIDTH = WINDOW_WIDTH - BALL_WIDTH_HEIGHT
MAX_HEIGHT = WINDOW_HEIGHT - BALL_WIDTH_HEIGHT

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH,WINDOW_HEIGHT))
clock = pygame.time.Clock()

#load images
ballImage = pygame.image.load("images/ball.png")
ballRect = ballImage.get_rect()
bounce_sound = pygame.mixer.Sound("sounds/boing.wav")
pygame.mixer.music.load("sounds/background.mp3")
pygame.mixer.music.play(-1,0.0)

#ball spawn position
MAX_WIDTH = WINDOW_WIDTH - ballRect.width
MAX_HEIGHT = WINDOW_HEIGHT - ballRect.height
ballRect.left = random.randrange(MAX_WIDTH)
ballRect.top = random.randrange(MAX_HEIGHT)

xSpeed = N_PIXELS_PER_FRAME
ySpeed = N_PIXELS_PER_FRAME
random.seed(3)
while True:

	for event in pygame.event.get():
		if event.type == pygame.QUIT:
			pygame.quit()
			sys.exit()

	if (ballRect.left<0) or (ballRect.right>=WINDOW_WIDTH):
		bounce_sound.play()
		xSpeed = -xSpeed
	if (ballRect.top<0) or (ballRect.bottom>=WINDOW_HEIGHT):
		bounce_sound.play()
		ySpeed = -ySpeed

	ballRect.left += xSpeed
	ballRect.top += ySpeed
		

	window.fill(BLACK)
	window.blit(ballImage, ballRect)
	pygame.display.update()
	clock.tick(FRAME_PER_SECOND)

