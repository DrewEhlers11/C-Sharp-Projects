using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {

             




            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel freee to look around the casino. Bye for now.");
            Console.Read();
        }

    }
}


//deck.Shuffle(3);                                                                //deck = Shuffle(deck, 3);   This is the call for the method shuffle

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();


            //string text = File.ReadAllText(@"C:\Users\Drew\Logs\log.txt");
            //File.WriteAllText(@"C:\Users\Drew\Logs\log.txt", text);

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            //public enum DaysOfTheWeek
            //{
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}


            //DaysOfTheWeek day = DaysOfTheWeek.Monday; 


            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);


            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame();
            //games.Add(game);


            // Overloading Operators
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;


            //Game game = new Game();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Method Creation for the method "Shuffle"
        



            //public static Deck Shuffle(Deck deck, int times)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}



            //deck.Cards = new List<Card>();

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);


            //Console.WriteLine(deck.Cards[0] + " of " + deck.Cards[0].Suit);

            // //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            // //List<Card> newList = Deck.Cards.Where(x => x.Face == Face.King).ToList();

            // List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            ///* int sum = numberList.Sum;//OR//*/ /*Max, Min (values in list);*/


            // int sum2 = numberList.Where(x => x > 20).Sum();

            // Console.WriteLine(sum2);
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //Console.WriteLine(count);