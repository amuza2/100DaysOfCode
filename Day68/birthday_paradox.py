import random, datetime

number_of_birthdays = 23

dates = []


for i in range(100000):
	if i % 5000 == 0:
		print("reached",i)
	for j in range(number_of_birthdays):
		day = random.randint(1, 28)
		month = random.randint(1, 12)
		dates.append(datetime.datetime(2023, month=month, day=day))

for i in range(number_of_birthdays):
	print(dates[i].strftime("%b %d"), end=", ")