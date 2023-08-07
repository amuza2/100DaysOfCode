# Blackjack

import random
import re
import os
import sys
# Draw the cards

player_money = 5000

def draw_cards():
    card_drawn = []
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
            if (val == "10"):
                card = f" ___ \n|{val} |\n| {sign} |\n|_{val}|"
            else:
                card = f" ___ \n|{val}  |\n| {sign} |\n|__{val}|"
            card_drawn.append(card)
    return card_drawn

blank_card = " ___ \n|## |\n|###|\n|_##|"

# Logic


def draw_players_cards(players_list, blank_Card=None):
    printing_list = ["", "", "", ""]
    for i in range(len(players_list)):
        if (i > 0 and blank_Card != None):
            a = blank_Card.split('\n')
        else:
            a = players_list[i].split('\n')
        printing_list[0] += a[0] + ' '
        printing_list[1] += a[1] + ' '
        printing_list[2] += a[2] + ' '
        printing_list[3] += a[3] + ' '
    for i in printing_list:
        print(i)


def get_bet(max_money):
    """Ask the user to bet and return it

    Args:
        max_money (int): Max money player can bet

    Returns:
        int: amount of money entered
    """
    while True:
        print("How much do you want to bet? (1-5000, or (Q)uit")
        bet_amount = input("> ")
        if bet_amount.upper() == "Q":
            print("Thanks for playing!")
            sys.exit()
        if (not bet_amount.isdigit()):
            os.system('cls')
            print("Please Enter digit number")
            continue # if value interedis not a digit, ask again

        bet_amount = int(bet_amount)
        if 1 <= bet_amount <= max_money:
            return bet_amount


def get_card_value(index, card_drawn):
    """Summary

    Args:
        index (int): index of random card
        card_drawn (list): list of cards

    Returns:
        int: returns the value of a cards
    """
    val = 0
    card = card_drawn[index]
    card_value_found = re.findall(r"[\dA-Z]+", card)[0]
    # print("card_value_found: " + card_value_found)
    if(card_value_found == 'J' or card_value_found == 'Q' or card_value_found == 'K'):
        val += 10
    elif (card_value_found == 'A'):
        val += 1
        if (val + 10 <= 21):
            val += 10
    else:
        val += int(card_value_found)
    return val

# Start playing
while True:
    # Exit if player has no money to play with
    if (player_money <= 0):
        print("You don't have enough money to play")
        break
    card_drawn = draw_cards()
    os.system('cls')
    dealer_card_count = 0
    player_card_count = 0
    dealer_bet_cards = []
    player_bet_cards = []
    print("Money: " + str(player_money))
    bet_amount = get_bet(player_money)
    
    # Exit if player hit Q
    if(str(bet_amount).upper() == 'Q'):
        break
    if(bet_amount > player_money):
        print("You don't have enough money to bet that amount!")

    print("Bet: " + str(bet_amount))
    print()

    # Dealer Part
    print("DEALER: ???")
    # Get two cards for the dealer
    for i in range(2):
        index = random.randint(0, len(card_drawn) - 1)
        card_value_result = get_card_value(index, card_drawn)
        dealer_card_count += card_value_result
        dealer_bet_cards.append(card_drawn[index])
        del card_drawn[index]
    
    # Draw cards in the Console
    draw_players_cards(dealer_bet_cards, blank_card)

    print()

    # Player part
    # Get two Cards for the player
    for i in range(2):
        index = random.randint(0, len(card_drawn) - 1)
        card_value_result = get_card_value(index, card_drawn)
        player_card_count += card_value_result
        player_bet_cards.append(card_drawn[index])
        del card_drawn[index]

    print("PLAYER: " + str(player_card_count))
    draw_players_cards(player_bet_cards)
    print()

    # Ask the user to hit, stop or quit
    while True:
        print("(H)it, (S)tand, (D)ouble down, (Q)uit")
        player_choice = input("> ")
        if(player_choice.upper() == 'H'):
            index = random.randint(0, len(card_drawn) - 1)
            card_value_result = get_card_value(index, card_drawn)
            player_card_count += card_value_result
            player_bet_cards.append(card_drawn[index])
            print(card_drawn[index])
            del card_drawn[index]
            print("Player: " + str(player_card_count))
        elif player_choice.upper() == 'S':
            break
        elif player_choice.upper() == 'Q':
            print("Thanks for playing!")
            sys.exit()
        else:
            print("Double is not programmed yet")

    print()

    # Dealer additional cards if cards count is less then 17
    while (dealer_card_count < 17):
        index = random.randint(0, len(card_drawn) - 1)
        card_value_result = get_card_value(index, card_drawn)
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
