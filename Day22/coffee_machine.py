#coffee machine
import emojis

coffee_emoji = emojis.encode(":coffee:")
tea_emoji = emojis.encode(":tea:")

money = 0
coffee_price = 40
tea_price = 30
products_list = {'1':coffee_price,'2':tea_price}

def ask_buyer(): 
	return int(input("add money to buy: "))

def choose_product():
	print('*'*10)
	print("1- Coffee\n2- tea")
	return input("What do you want to buy: ")

def sell_product(money,products_list,product_to_buy):
	while money<products_list[product_to_buy]:
		money_needed = products_list[product_to_buy] - money 
		print(f"no enough money, you need {money_needed}")
		money_added = ask_buyer()
		money += money_added

	if product_to_buy=='1':
		print(f"here is your Coffee {coffee_emoji}")
	else:
		print(f"here is your Tea {tea_emoji}")
	

	money = money-products_list[product_to_buy]
	return money

def show_money_left(money,products_list,product_to_buy):
	if money!=0:
		print(f"here is your money left {money}")
	else:
		print("no money left")

def main():
	money = ask_buyer()
	product = choose_product()
	money_left = sell_product(money, products_list, product)
	show_money_left(money_left,products_list,product)

main()
