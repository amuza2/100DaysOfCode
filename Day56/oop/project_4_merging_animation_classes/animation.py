import time
import pygame
from abc import ABC, abstractmethod


class Animation(ABC):

    @abstractmethod
    def __init__(self, window, loc, duration_per_image, loop=False):
        self.window = window
        self.loc = loc
        self.duration_per_image = duration_per_image
        self.loop_animation = loop

    def play(self):
        if self.playing:
            return
        self.playing = True
        self.image_start_time = time.time()
        self.index = 0

    def continue_animation(self):
        self.playing = True
        self.image_start_time = time.time()

    def draw(self):
        the_image = self.image_list[self.index]
        self.window.blit(the_image, self.loc)

    @property
    def loop_animation(self):
        return self.loop

    @loop_animation.setter
    def loop_animation(self, loop):
        self.loop = loop

    def stop_playing(self):
        self.playing = False

    def start_first_index(self):
        self.index = 0
