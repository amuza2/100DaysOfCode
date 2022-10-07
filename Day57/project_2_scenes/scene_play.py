# scene play

import pygwidgets
import pyghelpers
import pygame
from constants import *
import random

class ScenePlay(pyghelpers.Scene):
	def __init__(self, window):
		self.window = window
		self.RPSTuple = (ROCK, PAPER, SCISSORS)

	def get_scene_key(self):
		return SCENE_PLAY

	def handle_inputs(self, events_list, key_pressed_list):
		play_choice = None
		for event in events_list:
			if self.rock_button.handleEvent(event):
				play_choice = ROCK
			if self.paper_button.handleEvent(event):
				player_choice = PAPER
			if self.scissor_button.handleEvent(event):
				player_choice = SCISSORS

			if player_choice is not None:
				pass