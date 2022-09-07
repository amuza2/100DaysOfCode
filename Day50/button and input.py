import pygwidgets
import pygame
import sys

BLACK = (0,0,0)
WINDOW_WIDTH = 640
WINDOW_HEIGHT = 480
FRAME_PER_SECONDS = 30

pygame.init()
window = pygame.display.set_mode((WINDOW_WIDTH, WINDOW_HEIGHT))
clock = pygame.time.Clock()

oInputText = pygwidgets.InputText(window, (100,100), "",textColor=BLACK,fontSize=50)
oButtonText = pygwidgets.TextButton(window, (100,300), "Button")
while True:

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
        oInputText.handleEvent(event)
        if oButtonText.handleEvent(event):
            userText = oInputText.getValue()
            print("You added a string:", userText)

    window.fill(BLACK)    
    oInputText.draw() 
    oButtonText.draw()  
    pygame.display.update()
    clock.tick(FRAME_PER_SECONDS)