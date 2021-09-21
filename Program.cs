using System;

namespace Lernatelier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Figgle.FiggleFonts.Standard.Render("GUESS GAME : )"));
            Boolean noOfGame = true;
            int gamePlayed = 0;
            while (noOfGame)
            {
              
                bool wantsToPlay = true; 
                while (wantsToPlay)
                {
                    bool Continue = true;
                    int attempts = 1;
                    int x = new Random().Next(1, 101);
                    Console.WriteLine("Welcome to Guess a Word Program (0-100). Can you guess one number?");
                    while (Continue)
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n" + "Your guess:");
                            int guess = Convert.ToInt32(Console.ReadLine());
                            if (x > guess)
                            {
                                int triestook = attempts++;
                                Console.WriteLine("Sorry! the number I have in my mind is higher than " + guess + ". Can you guess what it is?");
                            }
                            if (x < guess)
                            {
                                int triestook = attempts++;
                                Console.WriteLine("Sorry! the number I have in my mind is lower than " + guess + ". Can you guess what it is?");
                            }
                            if (x == guess)
                            {
                                int triestook = attempts++;
                                gamePlayed++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Well done! The answer was " + x + " and you found it in " + triestook + " guesses.");
                                Console.WriteLine("Do you want to play again? If yes press[y], If not press Enter");
                                string tryAgain = Convert.ToString(Console.ReadLine());
                                if (tryAgain == "y")
                                {
                                    wantsToPlay = false;
                                    Continue = false;

                                }
                                else
                                {
                                    wantsToPlay = false;
                                    Continue = false;
                                    noOfGame = false;
                                    Console.WriteLine("You have played " + gamePlayed + " rounds");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("False input");
                        }
                    }

                }

            }
        }
    }
}


        

