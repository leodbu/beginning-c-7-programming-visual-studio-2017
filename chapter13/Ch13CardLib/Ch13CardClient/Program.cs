using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ch13CardClient
{
    public class Program
    {

        public static void Main(string[] args)
        {
            WriteLine("BenjaminCards: a new and exciting card game.");
            WriteLine("To win you must have 7 cards of the same suit in your hand.");

            WriteLine();

            // Prompt for number of players
            bool inputOK = false;
            int choice = -1;
            do
            {
                WriteLine("How many players (2 - 7) ?");
                string input = ReadLine();

                try
                {
                    // Attempt to convert input into a valid number of players.
                    choice = Convert.ToInt32(input);

                    if ((choice >= 2) && (choice <= 7)) inputOK = true;

                }
                catch
                {
                    // Ignore failed conversions, just continue  prompting
                }
            } while (inputOK == false);


            // Initialized array of Player objects.
            Player[] players = new Player[choice];
            // Get player names

            for (int p = 0; p < players.Length; p++)
            {
                WriteLine($"Player {p + 1}, enter your name :");
                string playerName = ReadLine();
                players[p] = new Player(playerName);
            }

            // Start Game.

            Game newGame = new Game();
            newGame.SetPlayers(players);
            int whoWon = newGame.PlayGame();
            WriteLine($"{players[whoWon].Name} has won the game!.");
            ReadKey();

        }

    }
}
