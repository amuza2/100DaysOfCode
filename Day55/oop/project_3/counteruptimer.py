from this import d
import time


class CounterUpTimer():

    def __init__(self):
        self.running = False
        self.time_elapsed = 0

    def start(self):
        if self.time_elapsed == 0:
            self.begin_time = time.time()
        else:
            self.begin_time = time.time() - self.time_elapsed
        self.running = True

    def stop(self):
        self.running = False

    def update(self):
        if not self.running:
            return False
        self.time_elapsed =  time.time() - self.begin_time

    def show_time(self):
        return self.get_time_formated(self.time_elapsed)

    def get_time_formated(self, time_in_seconds = 0):
        nSeconds = self.time_elapsed
        mins, secs = divmod(nSeconds, 60)
        hour, mins = divmod(int(mins), 60)

        if time_in_seconds > 0:
            seconds_width = time_in_seconds + 3
        else:
            seconds_width = 2
        
        if hour > 0:
            output = f"{hour:d}:{mins:02d}:{secs:0{seconds_width}.{time_in_seconds}f}"
        elif mins > 0:
            output = f"{mins:d}:{secs:0{seconds_width}.{time_in_seconds}f}"
        else:
            output = f"{secs:0{seconds_width}}f"
        return output