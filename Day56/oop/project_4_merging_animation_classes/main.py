from simpleanimation import SimpleAnimation
from spreedsheetanimation import SimpleSpriteSheetAnimation
import pygame
from pygame.locals import *
import sys
import pygwidgets
import os


BLACK = (0, 0, 0)
WHITE = (255, 255, 255)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 400
FRAMES_PER_SECOND = 30

pygame.init()

clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

start_button = pygwidgets.TextButton(window, loc=(10, 300), text="Start")

# oAnimation = SimpleAnimation(window, loc=(
# 190, 100), duration_per_image=.1, pic_paths=os.listdir("images/animation_images"))
oAnimation = SimpleSpriteSheetAnimation(window, loc=(
    190, 100), image_path="images/Monster.png", n_images=8, width=32, height=32, duration_per_image=.1)

while True:
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
        if start_button.handleEvent(event):
            oAnimation.play()
    oAnimation.update()

    window.fill(WHITE)
    oAnimation.draw()
    start_button.draw()
    pygame.display.update()
    clock.tick(FRAMES_PER_SECOND)
