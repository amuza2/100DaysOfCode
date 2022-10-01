import pygame
import time
from animation import Animation


class SimpleAnimation(Animation):

    def __init__(self, window, loc, pic_paths, duration_per_image, loop):
        self.image_list = []
        self.playing = False
        self.index = 0
        for pic_path in pic_paths:
            image = pygame.image.load("images/animation_images/" + pic_path)
            image = pygame.Surface.convert_alpha(image)
            self.image_list.append(image)
        self.n_images = len(self.image_list)
        super().__init__(window, loc, duration_per_image, loop)

    def update(self):
        if not self.playing:
            return
        self.elapsed = time.time()
        if self.elapsed > self.duration_per_image:
            self.index += 1
            if self.index < self.n_images:
                self.image_start_time = time.time()
            else:
                self.playing = False
                self.index = 0
