using System;
using System.Collections.Generic;

public class Deck
{
    static readonly Random rand = new Random();
    readonly List<Card> deck = new List<Card>();
    public List<Card> discard = new List<Card>();
    public Deck()
    {
        for (int suit = 1; suit <= 4; suit++)
        {
            for (int value = 1; value <= 13; value++)
            {
                Card card = new Card
                {
                    Value = value,
                    Suit = suit
                };
                deck.Add(card);
            }
        }
    }

    public void Display()
    {
        foreach (Card card in deck)
        {
            Console.WriteLine("Suit: {0} Value: {1}", card.Suit, card.Value);
        }
    }

    public void Shuffle()
    {
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            Card value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }
    public Card Deal()
    {
        Card newCard = deck[0];
        deck.RemoveAt(0);
        return newCard;
    }

    public void Discard()
    {

    }
}
