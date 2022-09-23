import time

class ElapsedTime():
	def __init__(self, time_legth = 2.5):
		self.time_legth = time_legth
		self.timer_running = False
		self.time_started = 0
		self.elapsed = 0

	def start_time(self):
		self.time_started = time.time()
		self.timer_running = True

	def update(self):
		self.elapsed = time.time() - self.time_started

	def check_time(self):
		if self.elapsed >= self.time_legth:
			self.timer_running = False
			return True

	@property
	def action_time(self):
		return self.timer_running
