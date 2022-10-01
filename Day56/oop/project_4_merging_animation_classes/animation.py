import time
import pygame


class Animation():

    def __init__(self, window, loc, duration_per_image):
        self.window = window
        self.loc = loc
        self.duration_per_image = duration_per_image

    def play(self):
        if self.playing:
            return
        self.playing = True
        self.image_start_time = time.time()
        self.index = 0

    def draw(self):
        the_image = self.image_list[self.index]
        self.window.blit(the_image, self.loc)
