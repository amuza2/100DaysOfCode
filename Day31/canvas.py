from PIL import Image
import numpy as np


class Canvas:

    def __init__(self, height, width, color):
        self.color = color
        self.height = height
        self.width = width

        self.data= np.zeros((self.height, self.width, 3), dtype=np.uint8)
        self.data[:] = self.color

    def make(self, image_path):
        img = Image.fromarray(self.data, "RGB")
        img.save(image_path) 


