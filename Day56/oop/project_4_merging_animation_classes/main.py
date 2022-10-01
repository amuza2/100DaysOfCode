from simpleanimation import SimpleAnimation
from spreedsheetanimation import SimpleSpriteSheetAnimation
import pygame
from pygame.locals import *
import sys
import pygwidgets
import os


BLACK = (0, 0, 0)
GREY = (128, 128, 128)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 400
FRAMES_PER_SECOND = 30

pygame.init()

clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

oAnimation = SimpleSpriteSheetAnimation(window, loc=(
    250, 50), image_path="images/water.png", n_images=40, width=192, height=192, duration_per_image=.05, loop=True)

start_button = pygwidgets.TextButton(window, loc=(10, 100), text="Start")
continue_button = pygwidgets.TextButton(window, loc=(10, 150), text="Continue")
stop_button = pygwidgets.TextButton(window, loc=(10, 200), text="Stop")
check_loop = pygwidgets.TextCheckBox(
    window, loc=(10, 260), text="Loop", value=oAnimation.loop_animation)

# oAnimation = SimpleAnimation(window, loc=(
# 190, 100), duration_per_image=.1, pic_paths=os.listdir("images/animation_images"))

while True:
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
        if start_button.handleEvent(event):
            oAnimation.play()

        elif continue_button.handleEvent(event):
            oAnimation.continue_animation()

        elif stop_button.handleEvent(event):
            oAnimation.stop_playing()

        elif check_loop.handleEvent(event):
            if not check_loop.getValue():
                check_loop.setValue(False)
                oAnimation.loop_animation = False
            else:
                check_loop.setValue(True)
                oAnimation.loop_animation = True
    oAnimation.update()

    window.fill(GREY)
    oAnimation.draw()
    start_button.draw()
    continue_button.draw()
    stop_button.draw()
    check_loop.draw()
    pygame.display.update()
    clock.tick(FRAMES_PER_SECOND)
