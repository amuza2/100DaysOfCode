"""
	For the first time I explore the threading module
	in this file will be examples of how to use this library
	to make code run fast

"""

import threading

def prime(number):
	prime_list = []
	for i in range(1,number+1):
		if i%2 == 0:
			prime_list.append(i)
	print("prime numbers are: "+ prime_list)


if __name__ == "__main__":
	x = threading.Thread(target=prime, args=(1000,))
	x.start()
