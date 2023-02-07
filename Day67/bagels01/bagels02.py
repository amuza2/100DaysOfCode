import random, os

numbers_length = 3
def menu():
	print(f"""
I am thinking of {numbers_length} digits number. try to guess what it is.
here are some clues:
When I say:	        That means:
   Pico               One digit is correct but in the wrong position.
   Fermi              One digit is correct and in the right position.
   Bagels             No digit is correct.
I have thought up a number.
You have 10 guesses to get it.
		""")

def get_random_numbers(length=3):
	answer = ''
	for i in range(length):
		answer += str(random.randint(0,9))
	return answer

def main():
	play = True
	while play:
		number_of_tries = 10
		game_result = False
		menu()
		answer = get_random_numbers()
		print("the result is:", answer)

		while number_of_tries > 0:
			
			# make sure you enter the correct length
			while True:
				guess = input(f"Guess number {abs(number_of_tries - 10) + 1}: ")
				if len(guess) == numbers_length:
					break

				# chack each number with the answer
			fermi, pico, bagels = 0, 0, 0
			for i in range(numbers_length):
				if guess[i] == answer[i]:
					fermi += 1
				elif guess[i] in answer:
					pico += 1
				else:
					bagels += 1

			# setup and print the result
			if fermi == numbers_length:
				game_result = True
				number_of_tries = -1
			elif bagels == numbers_length:
				print("Bagels")
			else:
				print(f"{fermi * 'Fermi '} {pico * 'Pico '}")

			number_of_tries -= 1

		# check if the user wants to play again
		if game_result:
			print("You got it right!")
		else:
			print("You finished all your tries\n \tGameOver")
		play_again = input("Do you want to play again: (Y/N)\n")
		if play_again.lower() == 'n':
			print("Goodby loser")
			play = False
		else:
			# clear the console once restarting the game
			os.system("cls")

if __name__ == '__main__':
	main()