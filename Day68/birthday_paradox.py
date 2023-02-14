import random
import datetime

number_of_birthdays = 23
matches = 0
for i in range(100_000):
    birthday = []
    dates = []
    if i % 5000 == 0:
        print("reached", i)
    for j in range(number_of_birthdays):
        day = random.randint(1, 28)
        month = random.randint(1, 12)
        dates.append(datetime.date(2023, month, day))
        birthday.append(dates[j].strftime("%b %d"))

    for z in range(number_of_birthdays):
        temp = birthday[z]
        birthday[z] = '*'
        if temp in birthday and temp != '*':
            matches += 1
            break
            # birthday[birthday.index(temp)] = '*'
        else:
            birthday[z] = temp

for i in range(number_of_birthdays):
    print(birthday[i], end=", ")
print("\nmatches:", matches)
