using System;
using System.Collections.Generic;

public class Player
{
	public string Name { get; set; }
	private static List<Card> hand = new List<Card>();
	public Player()
	{
		Name = GetName();
		Console.WriteLine("Hello {0}!", Name);
	}

	public string GetName()
	{
		Console.WriteLine("What is your name?");
		string name = Console.ReadLine();
		return name;
	}
	public void DealHand(Deck deck, int numberOfCards)
	{
		for (int i = 0; i < numberOfCards; i++)
		{
			hand.Add(deck.Deal());
		}
	}

	public void DisplayHand()
	{
		Console.Clear();
		string master = "";
		int counter = 0;
		foreach (Card card in hand)
		{
			master += counter + ")[";
			master += GetSuit(card);
			master += GetValue(card) + "]\n";
			counter++;
		}
		Console.WriteLine(master);
	}

	public List<Card> Discard()
	{
		Console.WriteLine("Which cards would you like to discard? (Ex: 1 4 6)");
		string[] response = Console.ReadLine().Split(" ");
		List<Card> cardIndexes = new List<Card>();

		for (int i = 0; i < response.Length; i++)
		{
			cardIndexes.Add(hand[int.Parse(response[i])]);
		}

		for (int i = response.Length - 1; i >= 0; i--)
		{
			hand.RemoveAt(int.Parse(response[i]));
		}

		return cardIndexes;
	}

	public string GetSuit(Card card)
	{
		switch (card.Suit)
		{
			case 1:
				return "\u2663";
			case 2:
				return "\u2666";
			case 3:
				return "\u2665";
			case 4:
				return "\u2660";
		}
		return "Invalid";
	}

	public string GetValue(Card card)
	{
		switch (card.Value)
		{
			case 1:
				return "A";
			case 2:
				return "2";
			case 3:
				return "3";
			case 4:
				return "4";
			case 5:
				return "5";
			case 6:
				return "6";
			case 7:
				return "7";
			case 8:
				return "8";
			case 9:
				return "9";
			case 10:
				return "10";
			case 11:
				return "J";
			case 12:
				return "Q";
			case 13:
				return "K";
		}
		return "Invalid";
	}

}
