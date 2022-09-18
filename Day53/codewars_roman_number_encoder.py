

class RomanNumber():

    units = {
            1:'I',
            2:'II',
            3:'III',
            4:'IV',
            5:'V',
            6:'VI',
            7:'VII',
            8:'VIII',
            9:'IX',
            }

    tens = {
            1:'X',
            2:'XX',
            3:'XXX',
            4:'XL',
            5:'L',
            6:'LX',
            7:'LXX',
            8:'LXXX',
            9:'XC',
            }

    hundreds = {
            1:'C',
            2:'CC',
            3:'CCC',
            4:'CD',
            5:'D',
            6:'DC',
            7:'DCC',
            8:'DCCC',
            9:'CM',
            }


    def __init__(self, number):
        self.result = ''
        self.number = str(number)
        self.check_len()
    
    def check_len(self):     
        if len(self.number) == 1:
            self.solve_units()
        elif len(self.number) == 2:
            self.solve_tens()
        elif len(self.number) == 3:
            self.solve_hundreds()
        elif len(self.number) == 4:
            self.solve_thousand()


    def solve_units(self): 
        self.result += self.units[int(self.number)]

    def solve_tens(self):
        self.result += self.tens[int(self.number[0])]
        self.number = str(int(self.number[1:]))
        if int(self.number) != 0:
            self.solve_units()

    def solve_hundreds(self):
        self.result += self.hundreds[int(self.number[0])]
        self.number = str(int(self.number[1:]))
        if int(self.number) != 0:
            self.check_len()

    def solve_thousand(self):
        self.result += int(self.number[0]) * 'M'
        self.number = str(int(self.number[1:]))
        if int(self.number) != 0:
            self.check_len()

    def get_value(self):
        return self.result

num = RomanNumber(1101)
print(num.get_value())





