
class CountingFrames():
	FRAMES_PER_SECOND = 30

	def __init__(self, timer_length = 2.5):
		self.timer_running = False
		self.n_frames_to_wait = int(CountingFrames.FRAMES_PER_SECOND * timer_length) 
		self.n_frames_elapsed = 0

	def active_counting(self):
		self.timer_running = True
		self.n_frames_elapsed = 0

	def update(self):
		if self.timer_running:
			self.n_frames_elapsed += 1
			if self.n_frames_elapsed >= self.n_frames_to_wait:
				self.timer_running = False
		return not self.timer_running

	def counter(self):
		return self.n_frames_elapsed
