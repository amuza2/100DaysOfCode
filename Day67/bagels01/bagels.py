import random, os

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
def get_random_numbers():
	answer = ""
	for i in range(3):
	    answer += str(random.randint(0, 9))
	print("the answer is: ", answer)
	return answer

def ask_to_play_again():
	play = False
	yes_or_no = input("Do you want to play again? [Y/N]\n")
	if yes_or_no.lower() == "y":
		play = True
	return play

def main():
	tries = 9
	guess_counter = 0
	play = False
	answer = get_random_numbers()
	while True:
		# show menu just when starting the game
		if not play:
			menu()
			play = True

		# make sure the length is equal to 3
		guess_counter += 1
		while True:
			guess = input(f"Guess #{guess_counter}: ")
			if len(guess) == 3:
				break

		# print how many tries 
		print(f"You have {tries} chance(s) left")

		#check each number position
		pico, fermi, bagel = 0, 0, 0
		for i in range(3):
			if guess[i] == answer[i]:
				fermi += 1
			elif guess[i] in answer:
				pico += 1
			else:
				bagel += 1

		if fermi == 3:
			print("You got it right!")
			if not ask_to_play_again():
				print("Thanks for playing")
				break
			else:
				os.system("cls")
				play = False
				guess_counter = 0
		elif bagel == 3:
			print("Bagels")
		else:
			print(f"{pico * 'Pico '} {fermi * 'fermi '}")

		# check if the user enter 10 tries
		if tries == 0:
			print("All your tries have finished!\nGame Over")
			print(f"the answer was :{answer}")
			if not ask_to_play_again():
				print("Thanks for playing")
				break
			else:
				play = False
				guess_counter = 0
				os.system("cls")
		tries -= 1

if __name__ == '__main__':
	main()