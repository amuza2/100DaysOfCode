import pygame

class TimerEvent():

	def __init__(self, timer_length = 2.5):
		self.timer_event_id = pygame.event.custom_type()
		self.timer_length = timer_length

	def start_timer(self):
		pygame.time.set_timer(self.timer_event_id, int(self.timer_length * 1000))

	def show_timer(self):
		return self.timer_event_id
