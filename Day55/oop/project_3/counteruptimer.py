import time


class CounterUpTimer():

    def __init__(self):
        self.running = False
        self.time_elapsed = 0

    def start(self):
        self.begin_time = time.time()
        self.running = True

    def continue_b(self):
        self.running = True
        self.begin_time = time.time() - self.time_elapsed

    def stop(self):
        self.running = False

    def update(self):
        if not self.running:
            return False
        self.time_elapsed =  time.time() - self.begin_time
        return True

    def show_time(self):
        return self.get_time_formated(self.time_elapsed)

    def get_time_formated(self, time_in_seconds = 0):
        seconds = time_in_seconds % (24 * 3600)
        hour = seconds // 3600
        seconds %= 3600
        minutes = seconds // 60
        seconds %= 60

        return "%d:%02d:%02d" % (hour, minutes, seconds)