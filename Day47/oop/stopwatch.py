from time import time


class StopWatch():
	
	def __init__(self, window):
		self.window = window
		self.active_counting = False
		self.paused = False
		self.gui_state = "idle"
		self.start_time = 0
		self.updated_time = None

	def start_count(self, ButtonEvent):
		if self.gui_state == "idle":
			self.active_counting = True
			self.gui_state = "running"
			self.window[ButtonEvent].update("Pause")			
		else:
			self.paused = True
			self.gui_state = "idle"
			self.active_counting = False
			self.window[ButtonEvent].update("Continue")

		if self.paused == False:
			self.start_time = time()

	def calculate_time(self, LabelEvent):
		if self.active_counting:
			if self.paused:
				self.updated_time += 0.015
				running_time = round(self.updated_time - self.start_time, 1)
			else:
				self.updated_time = time()
				running_time = round(self.updated_time - self.start_time, 1)
			self.window[LabelEvent].update(running_time)


	def stop_count(self, LabelEvent, ButtonEvent):
		self.active_counting = False
		self.gui_state = "idle"
		self.paused = False
		self.window[LabelEvent].update("0.0")
		self.window[ButtonEvent].update("Start")

