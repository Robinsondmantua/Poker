using ConsoleApp4;

int CARDS_IN_DECK = 52;

var deck = new Deck();

deck.Shuffle();

for (int i = 0;i < CARDS_IN_DECK; i++)
{
    var cardDealed = deck.PickUpACard();
    Console.WriteLine($"{cardDealed?.Value} of {cardDealed?.Suit}");
}

