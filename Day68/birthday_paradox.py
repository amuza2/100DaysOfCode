import random
import datetime

number_of_birthdays = 23
dates = []
matches = 0
birthday = []
for i in range(100_000):
    if i % 5000 == 0:
        print("reached", i)
    for j in range(number_of_birthdays):
        day = random.randint(1, 28)
        month = random.randint(1, 12)
        dates.append(datetime.date(2023, month, day))
        birthday.append(dates[j].strftime("%b %d"))

    for z in range(number_of_birthdays):
        temp = birthday[i]
        birthday[i] = '*'
        if temp in birthday:
            matches += 1
        birthday[i] = temp

for i in range(number_of_birthdays):
    print(birthday[i], end=", ")
print("matches:", matches)
