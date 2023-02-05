import random

def menu():
	print("""
I am thinking of 3 digits number. try to guess what it is.
here are some clues:
When I say:	        That means:
   Pico               One digit is correct but in the wrong position.
   Fermi              One digit is correct and in the right position.
   Bagels             No digit is correct.
I have thought up a number.
You have 10 guesses to get it.
		""")

answer = ""
for i in range(3):
    answer += str(random.randint(0, 9))
print("the answer is: ", answer)
tries = 9
guess_counter = 0
menu()
while True:
	# make sure the length is equal to 3
	guess_counter += 1
	while True:
		guess = input(f"Guess #{guess_counter}: ")
		if len(guess) == 3:
			break
	# print how many tries 
	print(f"You have {tries} chance(s) left")
	tries -= 1
	pico, fermi, bagel = 0, 0, 0

	#check each number position
	for i in range(3):
		if guess[i] == answer[i]:
			fermi += 1
		elif guess[i] in answer:
			pico += 1
			index = answer.index(guess[i])
			answer = list(answer)
			answer[index] = '*'
			answer = "".join(answer) 
		else:
			bagel += 1

	if fermi == 3:
		print("You got it right!")
		play = input("Do you want to play again? [Y/N]\n")
		if (play.lower() != 'y'):
			print("Thanks for playing")
			break
		else:
			guess_counter = 0
	elif bagel == 3:
		print("Bagels")
	else:
		print(f"{pico * 'Pico '} {fermi * 'fermi '}")