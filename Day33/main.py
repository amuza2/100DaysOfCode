import time
import random

class Sprite():
	def __init__(self, life, defence, damage):
		self.level = 1
		self.exp = 0
		self.life = life
		self.defence = defence
		self.damage = damage
		self.critical = 50
		self.penetration = 60

	def attack(self, user):
		if random.randint(1, 10) <= self.critical:
			if random.randint(1, 10) <= self.penetration:
				user.life -= self.damage*2
			else:	
				user.life -= (self.damage - user.defence)*2
		else:
			if random.randint(1, 10) <= self.penetration:
				user.life -= self.damage*2
			else:
				user.life -= self.damage - user.defence

class Hero(Sprite):
	pass


class Creature(Sprite):
	pass


class Boss(Sprite):
	pass

hero = Hero(150, 30, 40)
crops = Creature(50, 20, 50)

def attack_creature():
	crops_number = int(input("How many crops do you want to fight: "))
	print("""
		Do you want 
		  1- fast fight?
		  2- detailed fight?
		""")
	situation = int(input())
	if situation == 2:
		while True:
			print("you are attacking creature...")
			time.sleep(2)
			print("crop life is", crops.life)
			hero.attack(crops)
			print("crop life is", crops.life)
			if crops.life<=0:
				if crops_number > 1:
					crops_number -= 1
					print("crop is dead")
					print("crops left", crops_number)
					crops.life = 50
				else:
					print("crops dead you won!")
					break

			else:	
				print("crop life is ",crops.life)

			time.sleep(2)
			print("crop is attacking you...")
			time.sleep(2)
			print("hero life is", hero.life)
			for i in range(crops_number):
				crops.attack(hero)
				print("hero life is", hero.life)
			
			if hero.life<=0:
				print("you are dead, crop killed you!")
				break
			# print("Hero life is ",hero.life)

	else:
		while True:
			hero.attack(crops)
			if crops.life<=0:
				if crops_number > 1:
					crops_number -= 1
					crops.life = 50
				else:
					print("crops dead you won!")
					break

			for i in range(crops_number):
				crops.attack(hero)
			
			if hero.life<=0:
				print("you are dead, crops killed you!")
				break

def main():
	print("""
		1- Attack Creature
		2- Attack Boss

		what do you want to attack?
		""")
	choise = input()
	if choise == '1':
		attack_creature()
	else:
		print("not yet")

	
	

main()