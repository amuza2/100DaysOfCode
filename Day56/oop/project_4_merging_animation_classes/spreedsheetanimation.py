import pygame
import time
from animation import Animation


class SimpleSpriteSheetAnimation(Animation):

    def __init__(self, window, loc, image_path, n_images, width, height, duration_per_image):
        self.n_images = n_images
        self.image_list = []
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
            self.image_list.append(image)

            col += 1
            if col == n_cols:
                row += 1
                col = 0

        self.playing = False
        self.index = 0
        super().__init__(window, loc, duration_per_image)

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
