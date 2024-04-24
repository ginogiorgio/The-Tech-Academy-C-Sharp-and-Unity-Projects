using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			Game game = new TwentyOneGame();
			game.Players = new List<Player>();
			Player player = new Player();
			player.Name = "Gino";
			game += player;
			game -= player;


			Deck deck = new Deck();
			deck.Shuffle(times: 3);


			foreach (Card card in deck.Cards)
			{
				Console.WriteLine(card.Face + " of " + card.Suit);
			}

			Console.WriteLine(deck.Cards.Count);
			Console.ReadLine();
		}
	}
}
