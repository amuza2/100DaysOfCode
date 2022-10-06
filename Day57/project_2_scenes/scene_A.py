# Scene A

import pygwidgets
import pyghelpers
import pygame
from pygame.locals import *
from constants import *

class SceneA(pyghelpers.Scene):
	def __init__(self, window):
		self.window = window
		self.message_Field = pygwidgets.DisplayText(self.window, (15,25),
													"This is Scene A",
													fontSize=50,
													textColor=WHITE,
													width=610,
													justified="center")
		self.goto_A_Button = pygwidgets.TextButton(self.window,
													(250,100),
													"Go to Scene A")
		self.goto_B_Button = pygwidgets.TextButton(self.window,
													(250,100),
													"Go to Scene B")
		self.goto_C_Button = pygwidgets.TextButton(self.window,
													(400,100),
													"Go to Scene C")

		self.goto_A_Button.disable()

	def get_scene_key(self):
		return SCENE_A

	def handle_inputs(self, events_list, key_pressed_list):
		for event in events_list:
			if self.goto_B_Button.handleEvent(event):
				self.goToScene(SCENE_B)
			if self.goto_C_Button.handleEvent(event):
				self.goToScene(SCENE_C)

	def draw(self):
		self.window.fill(GRAY)
		self.message_Field.draw()
		self.goto_A_Button.draw()
		self.goto_B_Button.draw()
		self.goto_C_Button.draw()