import time

class CountDownTimer():

    def __init__(self, set_time):
        self.set_time = set_time * 60
        self.running = False
        self.elapsed_time = 0

    def start(self):
        self.begin_time = time.time()
        self.running = True

    def update(self):
        if not self.running:
            return False
        else:
            time_to_begin_with = self.begin_time + self.set_time
            self.elapsed_time = time_to_begin_with - time.time()
            if self.elapsed_time <= 0:
                self.running = False

    def stop(self):
        self.running = False
        self.elapsed_time = 0

    def show_time(self):
        return round(self.elapsed_time)

    def formated_time(self):
        seconds = self.elapsed_time % (24 * 3600)
        hour = seconds // 3600
        seconds %= 3600
        minutes = seconds // 60
        seconds %= 60

        if hour != 0:
            return "%d:%02d:%02d" % (hour, minutes, seconds)
        else:
            return "%02d:%02d" % (minutes, seconds)
