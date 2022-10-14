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
                computer_choice = random.choice(self.RPSTuple)
                data_dict = {"player": player_choice,
                             "computer": computer_choice}
                self.goToScene(SCENE_RESULT, data_dict)

    def draw(self):
        self.window.fill(GRAY)
        self.title_Field.draw()
        self.rock_button.draw()
        self.paper_button.draw()
        self.scissor_button.draw()
        self.message_field.draw()
