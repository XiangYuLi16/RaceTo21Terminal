using System;

namespace RaceTo21
{
    class Program
    {
        /// <summary>
        /// Instantiate game elements. Repeatedly prompt game to update until end condition detected.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CardTable cardTable = new CardTable();
            Game game = new Game(cardTable);
            while (true)
            {
                game.DoNextTask();

                // Check if the game is over
                if (game.nextTask == Task.GameOver)
                {
                    // Ask the players if they want to continue
                    Console.Write("Do you want to continue playing? (Y/N) ");
                    string response = Console.ReadLine();
                    if (response.ToUpper() != "Y")
                    {
                        Console.WriteLine("Thanks for playing!");
                        break; // Exit the loop and end the game
                    }
                    else
                    {
                        game.RestartGame(); // Restart the game
                    }
                }
            }
        }
    }
}

