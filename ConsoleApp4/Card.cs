using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Card
    {
        public string Value { get; private set; } 
        public string Suit { get; private set; }

        public Card(string value, string suit) {
            Value = value;
            Suit = suit;
        }
    }
}
