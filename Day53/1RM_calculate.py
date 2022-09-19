class OneRamCalculator():
    def __init__(self, weight, repetition):
        self.result = []
        self.weight = weight
        self.repetition = repetition
        self._start_calculate_1RM()


    def _start_calculate_1RM(self):
        w = self.weight
        r = self.repetition
        if r == 0:
            return 0
        elif r == 1:
            return w
        way_1 = w * (1 + (r/30))
        way_2 = (100 * w) / (101.3 - (2.67123*r))
        way_3 = w * (r ** 0.1)
        self.result = [way_1,way_2,way_3]
        return round(max(self.result))

    @property
    def get_result(self):
        return self._start_calculate_1RM()

def calculate_1RM(w, r):
    answer = OneRamCalculator(200, 8)
    return answer.get_result
