using System;
using System.Collections.Generic;

public class Hand
{
    readonly List<Card> hand = new List<Card>();
    public List<Card> discard = new List<Card>();

    public Hand(Deck deck, int numberOfCards)
    {
        for (int i = 0; i < numberOfCards; i++)
        {
            hand.Add(deck.Deal());
        }
    }
}
