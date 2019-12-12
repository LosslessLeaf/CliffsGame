using System;
using System.Collections.Generic;

public class Game
{
    public Game()
    {
        Deck deck = new Deck();
        List<Player> players = new List<Player>();

        deck.Shuffle();

        Console.WriteLine("Welcome to Cliff's Game!");
        Console.WriteLine("press enter to continue...");
        Console.ReadLine();
        Console.Clear();

        Player player1 = new Player();

        player1.DealHand(deck, 8);
        player1.DisplayHand();
        player1.Discard();
        player1.DisplayHand();
    }

}