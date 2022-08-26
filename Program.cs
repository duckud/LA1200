using System;

namespace number_guessing
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                try
                {

                    Random random = new Random();
                    int Zufallszahl = random.Next(1, 100);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Try to guess the random number! It's a number between 1 and 100.");
                    Console.WriteLine("enter Number:");
                    string userinput = Console.ReadLine();
                    int x = Int32.Parse(userinput);

                    int attempts = 0;

                    int frequency = 1800;
                    int duration = 500;

                    if (x > 100 || x < 1)
                    {
                        throw new Exception();


                    }
                    else
                        while (x != Zufallszahl)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Beep();
                            Console.WriteLine("You guessed wrong!");

                            if (x < Zufallszahl)
                            {

                                Console.WriteLine("The secret number is higher than" + " " + x);


                            }
                            else
                                Console.WriteLine("The secret number is lower than" + " " + x);


                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Please enter a new number:");
                            x = Int32.Parse(Console.ReadLine());
                            attempts = attempts + 1;
                        }

                    if (x == Zufallszahl)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Beep(frequency, duration);
                        Console.WriteLine("Correct!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You guessed wrong " + attempts + " times in total.");
                        Console.ReadKey();
                        break;
                    }
                }
                     
                



                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("There was an issue, please try again.");
                    Console.WriteLine("Press enter to play again");
                }
                Console.ReadKey();

            }

        }

             }
        }
    

