import time
import random
import ipdb
import os
import json

class Sprite():
	def __init__(self, life, defence, damage):
		self.level = 1
		self.max_life = 150
		self.exp = 0
		self.life = life
		self.defence = defence
		self.damage = damage
		self.critical = 50
		self.penetration = 60
		self.boss_level = 1

	def attack(self, user):
		if random.randint(1, 100) <= self.critical:
			if random.randint(1, 100) <= self.penetration:
				user.life -= abs(self.damage*2)
				# print("critical and penetration used")
			else:	
				user.life -= abs((self.damage - user.defence)*2)
				# print("critical used")
		else:
			if random.randint(1, 100) <= self.penetration:
				user.life -= self.damage
				# print("penetration used")
			else:
				user.life -= abs(self.damage - user.defence)
				# print("no skill used")

class Hero(Sprite):
	pass


class Creature(Sprite):
	pass


class Boss(Sprite):
	pass

hero = Hero(150, 30, 40)
crops = Creature(50, 5, 20)

def save_game():
	data = {"level":hero.level,"max_life":hero.max_life,"exp":hero.exp,"life":hero.life,"defence":hero.defence,"damage":hero.damage,"critical":hero.critical,"penetration":hero.penetration,"boss_level":hero.boss_level}
	with open("game_saved.json", 'w') as f:
		json.dump(data, f)
		
def load_game():
	with open("game_saved.json") as f:
		data = json.load(f)
	
	hero.level = data["level"]
	hero.life = data["life"]
	hero.max_life = data["max_life"]
	hero.exp = data["exp"]
	hero.defence = data["defence"]
	hero.damage = data["damage"]
	hero.critical = data["critical"]
	hero.penetration = data["penetration"]
	hero.boss_level = data["boss_level"]

def display_game_info(user):
	print(f"\tlife: {user.life}\n\tdamage: {user.damage}\n\tdefence: {user.defence}\n\tLevel: {user.level}")

def level_up():
	hero.life = hero.max_life
	hero.level += 1
	hero.exp = 0
	print(f"your level is {hero.level}")
	print()
	print("""
		Choose skill you want to level up:
		1- Life
		2- Defence
		3- Damage
		4- Critical hit
		5- Penetration
		""")
	option = int(input())
	if option == 1:
		hero.max_life += 10
		hero.life += 10
		print(f"Now you have {hero.life} life")
	elif option == 2:
		hero.defence += 2
		print(f"Now you have {hero.defence} defence")
	elif option == 3:
		hero.damage += 2
		print(f"Now you have {hero.damage} damage")
	elif option == 4:
		if hero.critical < 90:
			hero.critical += 1
			print(f"Now you have {hero.critical} critical")
	elif option == 5:
		if hero.penetration < 50:
			hero.penetration += 1
			print(f"Now you have {hero.penetration} penetration")
	else:
		pass

def attack_creature():
	crops_number = int(input("How many crops do you want to fight: "))
	CROPS = crops_number
	get_exp = False
	if crops_number > 1:
		get_exp = True
	print("""
		Do you want 
		  1- fast fight?
		  2- detailed fight?
		""")
	situation = int(input())
	if situation == 2:
		while True:
			print("*---------------------------*")
			print("HERO:")
			display_game_info(hero)
			print("Crops:")
			display_game_info(crops)
			print()
			print("you are attacking creature...")
			# time.sleep(2)
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
					crops.life = 50
					if get_exp:
						hero.exp += CROPS * 50
						if hero.exp >= hero.level*100:
							level_up()
					# break

			# time.sleep(2)
			print("crop is attacking you...")
			# time.sleep(2)
			print("hero life is", hero.life)
			for i in range(crops_number):
				# ipdb.set_trace()
				crops.attack(hero)
				print("hero life is", hero.life)
			
			if hero.life<=0:
				print("you are dead, crop killed you!")
				hero.life = hero.max_life
				break
			print("*                           *")
			print("*---------------------------*")

	else:
		while True:
			hero.attack(crops)
			if crops.life<=0:
				if crops_number > 1:
					crops_number -= 1
					crops.life = 50
				else:
					print("crops dead you won!")
					crops.life = 50
					# ipdb.set_trace()
					if get_exp:
						hero.exp += CROPS * 50
						if hero.exp >= hero.level*100:
							level_up()
					else:
						hero.exp += 50
						if hero.exp >= hero.level*100:
							level_up()
					break

			for i in range(crops_number):
				crops.attack(hero)
			
			if hero.life<=0:
				print("you are dead, crops killed you!")
				hero.life = hero.max_life
				break

def boss_attack():
	boss = Sprite(100+10*hero.boss_level, 20+2*hero.boss_level, 35+3*hero.boss_level)
	print("HERO:")
	display_game_info(hero)
	print("BOSS:")
	display_game_info(boss)
	print("""
		Do you want 
		  1- fast fight?
		  2- detailed fight?
		""")
	situation = int(input())
	if situation == 2:
		while True:
			print("*---------------------------*")
			print("*                           *")
			print("you are attacking Boss...")
			print("Boss life is", boss.life)
			hero.attack(boss)
			print("Boss life is", boss.life)
			if boss.life<=0:
				print("Boss dead you won!")
				if hero.boss_level<=100:
					hero.boss_level += 1
				else:
					print("You Finished the game!")
				break

			print("Boss is attacking you...")
			print("hero life is", hero.life)
			boss.attack(hero)
			print("hero life is", hero.life)
			
			if hero.life<=0:
				print("you are dead, Boss killed you!")
				hero.life = hero.max_life
				break
			print("*                           *")
			print("*---------------------------*")
	else:
		while True:
			hero.attack(boss)
			if boss.life<=0:
				print("Boss dead you won!")
				hero.boss_level += 1
				break
			boss.attack(hero)			
			if hero.life<=0:
				print("you are dead, Boss killed you!")
				hero.life = hero.max_life
				break

def main():
	while True:
		print("""
			1- Attack Creature
			2- Attack Boss
			3- Save game
			4- load game
			5- Exit

			what do you want to attack?
			""")
		choice = int(input())
		os.system("cls")
		if choice == 1:
			attack_creature()
		elif choice == 2:
			boss_attack()
		elif choice == 3:
			save_game()
		elif choice == 4:
			load_game()
		else:
			break

main()