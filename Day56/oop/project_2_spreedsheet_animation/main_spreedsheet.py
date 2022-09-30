import pygame
from pygame.locals import *
import sys
import pygwidgets
from spreedsheetanimation import SimpleSpriteSheetAnimation

WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAMES_PER_SECOND = 30
BGCOLOR = (0,128,128)

pygame.init()

clock = pygame.time.Clock()
window = pygame.display.set_mode([WINDOW_WIDTH, WINDOW_HEIGHT])

start_button = pygwidgets.TextButton(window, loc=(60, 320), text="Play")

oAnimation = SimpleSpriteSheetAnimation(window, loc=(22, 140),image_path="images/water.png",
                                        width=192, height=192,duration_per_image=.05,
                                        n_images=40)
while True:
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()

        if start_button.handleEvent(event):
            oAnimation.play()

    oAnimation.update()

    window.fill(BGCOLOR)
    oAnimation.draw()
    start_button.draw()
    pygame.display.update()
    clock.tick(FRAMES_PER_SECOND)