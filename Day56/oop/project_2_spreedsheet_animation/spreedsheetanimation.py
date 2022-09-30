import pygame
import time

class SimpleSpriteSheetAnimation():

    def __init__(self, window, loc, image_path, n_images, width, height, duration_per_image):
        self.window = window
        self.loc = loc
        self.n_images = n_images
        self.images_list = []
        sprite_sheet_image = pygame.image.load(image_path)
        sprite_sheet_image = pygame.Surface.convert_alpha(sprite_sheet_image)
        n_cols = sprite_sheet_image.get_width() // width
        row = 0
        col = 0
        for image_number in range(n_images):
            x = col * width
            y = row * height

            subsurface_rect = pygame.Rect(x, y, width, height)
            image = sprite_sheet_image.subsurface(subsurface_rect)
            self.images_list.append(image)

            col += 1
            if col == n_cols:
                row += 1
                col = 0

        self.duration_per_image = duration_per_image
        self.playing = False
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
        self.elapsed = time.time() - self.image_start_time
        if self.elapsed > self.duration_per_image:
            self.index += 1
            if self.index < self.n_images:
                self.image_start_time = time.time()
            else:
                self.playing = False
                self.index = 0

    def draw(self):
        the_image = self.images_list[self.index]
        self.window.blit(the_image, self.loc)