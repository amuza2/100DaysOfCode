import datetime, random

def get_birthdays(number_of_birthdays):
    birthdays = []
    for i in range(number_of_birthdays):
        start_of_the_year = datetime.date(2022,1,1)
        random_number_ofthe_day = datetime.timedelta(random.randint(0,364))
        birthday = start_of_the_year + random_number_ofthe_day
        birthdays.append(birthday)
    return birthdays

def get_match(birthdays):
    for a, birthdayA in enumerate(birthdays):
        for b, birthdayB in enumerate(birthdays[a + 1:]):
            if birthdayA == birthdayB:
                return birthdayA

paradox_counter = 0
for i in range(100_000):
    if i % 10_000 == 0:
        print("working on it", i)
    birthdays = get_birthdays(23)
    birth = get_match(birthdays)
    if birth != None:
        paradox_counter += 1
print(paradox_counter)