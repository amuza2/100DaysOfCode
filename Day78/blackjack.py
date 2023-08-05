# Blackjack

import random
import re
import os
# Draw the cards

card_drawn = []
d = []
player_money = 5000
def draw_cards():
    card_value = ['Ace', '2', '3', '4', '5',
                '6', '7', '8', '9', '10', 'J', 'Q', 'K']
    card_type = ['Hearts', 'Spades', 'Clubs', 'Diamonds']
    val = ""
    sign = ""

    for i in card_value:
        if (i == "Ace"):
            val = 'A'
        else:
            val = i
        for j in card_type:
            if (j == "Hearts"):
                sign = "\u2665"
            elif (j == "Spades"):
                sign = "\u2660"
            elif (j == "Clubs"):
                sign = "\u2663"
            else:
                sign = "\u2666"
            card = f" ___ \n|{val}  |\n| {sign} |\n|__{val}|"
            card_drawn.append(card)

blank_card = " ___ \n|## |\n|###|\n|_##|"

# Logic
def draw_players_cards(players_list, blank_Card = None):
    for i in range(len(players_list)):
        if(blank_Card != None and i != 0):
            print(blank_card, end = " ")
        else:
            print(players_list[i], end = " ")

def check_card_value(index, card_drawn):
    val = 0
    card = card_drawn[index]
    card_value_found = re.findall(r"[\dA-Z]+", card)[0]
    # print("card_value_found: " + card_value_found)
    if(card_value_found == 'J' or card_value_found == 'Q' or card_value_found == 'K'):
        val += 10
    elif (card_value_found == 'A'):
        v = random.randint(0, 1)
        if (v == 0):
            val += 1
        else:
            val += 11
    else:
        val += int(card_value_found)
    return val

while True:
    if (player_money > 0):
        print("You don't have enough money to play")
        break
    draw_cards()
    os.system('cls')
    dealer_card_count = 0
    player_card_count = 0
    dealer_bet_cards = []
    player_bet_cards = []
    print("Money: " + str(player_money))
    print("How much do you want to bet? (1-5000, or (Q)uit")
    bet_amount = int(input("> "))
    if(str(bet_amount).upper() == 'Q'):
        break
    if(bet_amount > player_money):
        print("You don't have enough money to bet that amount!")

    print("Bet: " + str(bet_amount))
    print()

    # Dealer Part
    print("DEALER: ???")
    for i in range(2):
        index = random.randint(0, len(card_drawn) - 1)
        card_value_result = check_card_value(index, card_drawn)
        dealer_card_count += card_value_result
        dealer_bet_cards.append(card_drawn[index])
        del card_drawn[index]

    draw_players_cards(dealer_bet_cards, blank_card)
    
    print()

    # Player part
    for i in range(2):
        index = random.randint(0, len(card_drawn) - 1)
        card_value_result = check_card_value(index, card_drawn)
        # print("card_value_result: " + str(card_value_result))
        player_card_count += card_value_result
        player_bet_cards.append(card_drawn[index])
        del card_drawn[index]
        # print("player_card_count: " + str(player_card_count))

    print("PLAYER: " + str(player_card_count))
    draw_players_cards(player_bet_cards)
    print()

    while True:
        print("(H)it, (S)tand, (D)ouble down, (E)ough")
        player_choice = input("> ")
        if(player_choice.upper() == 'H'):
            index = random.randint(0, len(card_drawn) - 1)
            card_value_result = check_card_value(index, card_drawn)
            player_card_count += card_value_result
            player_bet_cards.append(card_drawn[index])
            print(card_drawn[index])
            del card_drawn[index]
            print("Player: " + str(player_card_count))
        elif player_choice.upper() == 'S':
            break
        else:
            print("Double is not programmed yet")
            
    print()

    # Dealer additional cards if cards count is less then 17
    while (dealer_card_count < 17):
        index = random.randint(0, len(card_drawn) - 1)
        card_value_result = check_card_value(index, card_drawn)
        dealer_card_count += card_value_result
        dealer_bet_cards.append(card_drawn[index])
        print("Dealer new card(s)")
        print(card_drawn[index])
        del card_drawn[index]

    print()
    print("-------------")
    print("Dealer: " + str(dealer_card_count))
    draw_players_cards(dealer_bet_cards)
    print()
    print("Player: " + str(player_card_count))
    draw_players_cards(player_bet_cards)
    print()

    if(player_card_count > dealer_card_count and player_card_count <= 21):
        player_money += bet_amount
        print("Player Won")
    elif (player_card_count > dealer_card_count and player_card_count > 21):
        player_money -= bet_amount
        print("Dealer Won")
    elif (dealer_card_count > player_card_count and dealer_card_count <= 21):
        player_money -= bet_amount
        print("Dealer Won")
    elif (dealer_card_count > player_card_count and dealer_card_count > 21):
        player_money += bet_amount
        print("Player Won")
    else:
        print("IT's draw, money returned to the Player")

    input()


