import pygame
import time


class SimpleAnimation():
    
    def __init__(self, window, loc, pic_paths, duration_per_image):
        self.window = window
        self.loc = loc
        self.image_list = []
        for pic_path in pic_paths:
            print(pic_path)
            image = pygame.image.load("images/"+pic_path)
            image = pygame.Surface.convert_alpha(image)
            self.image_list.append(image)

        self.playing = False
        self.duration_per_image = duration_per_image
        self.n_images = len(self.image_list)
        self.index = 0

    def play(self):
        if self.playing:
            return 
        self.playing = True
        self.image_start_time = time.time()
        self.index = 0

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

    def draw(self):
        the_image = self.image_list[self.index]
        self.window.blit(the_image, self.loc)