from counteruptimer import CounterUpTimer
import pygame
from pygame.locals import *
import pygwidgets
import sys

BLACK = (0,0,0)
WHITE = (255,255,255)
WINDOW_WIDTH = 500
WINDOW_HEIGHT = 400
FRAMES_PER_SECONS = 30

pygame.init()

clock = pygame.time.Clock()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))

start_button = pygwidgets.TextButton(window, loc=(100,300),text="Start")
stop_button = pygwidgets.TextButton(window, loc=(300,300),text="Stop")
label_1 = pygwidgets.DisplayText(window, loc=(240,200),value='0',fontSize=36,textColor=WHITE)

oTimer = CounterUpTimer()

while True:
    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()

        if start_button.handleEvent(event):
            start_button.disable()
            oTimer.start()

        if stop_button.handleEvent(event):
            oTimer.stop()
            start_button.enable()

    label_1.setValue(oTimer.show_time())
    oTimer.update()

    window.fill(BLACK)
    start_button.draw()
    stop_button.draw()
    label_1.draw()
    pygame.display.update()
    clock.tick(FRAMES_PER_SECONS)