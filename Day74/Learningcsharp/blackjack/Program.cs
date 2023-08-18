using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Program
    {
        
        public static List<string> getCards()
        {
            List<string> cardsDeck = new List<string>();
            string[] card_values = new string[]
            {
                "Ace", "2", "3","4","5","6","7","8","9", "10",
            };
            string[] card_type = new string[]
            {
                "Hearts", "Spades", "Clubs", "Diamonds",
            };

            string val = "";
            string sign = "";
            string face = "";

            foreach (string card in card_values)
            {
                if (card.Equals("Ace")) val = "A";
                else val = card;

                foreach (string type in card_type)
                {
                    if (type.Equals("Hearts")) sign = "\u2665";
                    else if (type.Equals("Spades")) sign = "\u2660";
                    else if (type.Equals("Clubs")) sign = "\u2663";
                    else sign = "\u2666";

                    if (val.Equals("10"))
                    {
                        face = $" ___ \n|{val} |\n| {sign} |\n|_{val}|";
                    }
                    else
                    {
                        face = $" ___ \n|{val}  |\n| {sign} |\n|__{val}|";
                    }
                    cardsDeck.Add(face);
                }
            }

            return cardsDeck;
        }

        public static void run()
        {
            int playerMoney = 5000;
            string blankCard = " ___ \n|## |\n|###|\n|_##|";
            while (true)
            {
                // Exit if the player has no money to play with
                if(playerMoney <= 0)
                {
                    Console.WriteLine("You don't have enough money to play!");
                    break;
                }
                var deckOfCards = getCards();
                Console.Clear();
                int dealerCardCount = 0;
                int playerCardCount = 0;
                List<string> dealerBetCards = new List<string>();
                List<string> playerBetCards = new List<string>();
                Console.WriteLine("Money: " + playerMoney);
                int betAmount = getBet(playerMoney);

                Console.WriteLine("Bet: " + betAmount);
                Console.WriteLine();

                // Dealer Part
                Console.WriteLine("Dealer: ???");
                // get to know cards of the dealer
                for (int i = 0; i < 2; i++)
                {
                    Random random = new Random();
                    int index = random.Next(0,deckOfCards.Count() - 1);
                    int cardValueResult = getCardValue(index, deckOfCards);
                }
            }
        }

        private static int getCardValue(int index, List<string> deckOfCards)
        {
            // index (int): index of a random card
            // deckOfCards (List<string>): list of cards
            int val = 0;
            string card = deckOfCards[index];
            string cardValueFound = Regex.Matches(card, @"[A-Z0-9]+").ToString();
            Console.WriteLine(cardValueFound);
            return 0;
        }

        private static int getBet(int maxMoney)
        {
            // Ask the user to bet and return it
            // maxMoney (int): Max money player can bet

            while (true)
            {
                Console.WriteLine("How much do you want to bet? (1-5000, or (Q)uit)");
                Console.Write("> ");
                string betAmount = Console.ReadLine();
                if(betAmount.ToUpper() == "Q")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
                bool isNum = int.TryParse(betAmount, out int num);
                if(isNum == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a digit number!");
                    continue;
                }
                if (num >= 1 && num <= maxMoney) return num;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Make sure to enter a valid amount");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            run();


        }
    }
}
