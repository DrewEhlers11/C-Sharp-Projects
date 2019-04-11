using Casino;
using Casino.TwentyOne;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Guid identifier = Guid.NewGuid(); 

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            


            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your system Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel freee to look around the casino. Bye for now.");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.VarChar);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlConnection(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
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
            //var newPlayer = new Player("Jesse");

            // int sum2 = numberList.Where(x => x > 20).Sum();

            // Console.WriteLine(sum2);
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            //Console.WriteLine(count);