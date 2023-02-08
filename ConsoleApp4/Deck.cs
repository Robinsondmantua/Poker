using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Deck
    {
        private const int CARDS_IN_DECK = 52;
        private const int CARDS_IN_SUITS = 13;
        private Card[] deck;
        private Random cardChosen;
        private int currentCard;

        public Deck()
        {
            deck = new Card[CARDS_IN_DECK];
            cardChosen = new Random();

            string[] values = {"Ace", "Two", "Three", "Four", "Five",
                "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            for(int cardInDeck = 0; cardInDeck < deck.Length; cardInDeck++)
            {
                deck[cardInDeck] = new Card(values[cardInDeck % CARDS_IN_SUITS], suits[cardInDeck / CARDS_IN_SUITS]);
            }
        }

        public void Shuffle()
        {
            currentCard = 0;
            cardChosen = new Random();
            deck = deck.OrderBy(x => cardChosen.Next()).ToArray();
        }

        public Card? PickUpACard()
        {
            var hasCardsInTheMaze = currentCard < deck.Length;
            return hasCardsInTheMaze ? deck[currentCard++] : null;
        }
    }
}
