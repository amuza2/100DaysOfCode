import time

class Timer():

	def __init__(self, time_in_seconds, nickname = None, callback = None):
		self.time_in_seconds = time_in_seconds
		self.nickname = nickname
		self.callback = callback
		self.saved_seconds_elapsed = 0.0
		self.running = running

	def start(self, new_time_in_seconds=None):
		if new_time_in_seconds != None:
			self.time_in_seconds = new_time_in_seconds
		self.running = True
		self.start_time = time.time()

	def update(self):
		if not self.running:
			return False
		self.saved_seconds_elapsed = time.time() - self.start_time
		if self.saved_seconds_elapsed < self.time_in_seconds:
			return False
		else:
			self.running = False
			if self.callback != None:
				self.callback(self.nickname)
			return True

	def get_time(self):
		if self.running:
			self.saved_seconds_elapsed = time.time() - self.start_time
		return self.saved_seconds_elapsed


	def stop_timer(self):
		self.get_time()
		self.running = False

