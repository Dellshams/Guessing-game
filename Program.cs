using System;
using System.Collections.Generic;
using System.Linq;

namespace Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game");

            Console.WriteLine("Choose between Stages Easy, Medium and Hard");
            string Stage = Console.ReadLine();

            if (Stage == "Easy")
            {
                Console.WriteLine("You are playing the Easy Stage");

                int secret_num = 3;
                int guess = 0;
                int guess_count = 0;
                int guess_limit = 6;
                bool out_of_guesses = false;

                while ((guess != secret_num) || (!out_of_guesses))
                {
                    if (guess_count < guess_limit)
                    {
                        Console.WriteLine("Guess a number between 1 and 10: ");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == secret_num)
                        {
                            break;
                        }
                        else if (guess > 10)
                        {
                            Console.WriteLine("Out of guessing range");
                        }
                        ++guess_count;
                        int guesses = guess_limit - guess_count;
                        Console.WriteLine("That was wrong");
                        Console.WriteLine("You have "  + guesses + " guesses left");
                    }
                    else
                    {
                        out_of_guesses = true;
                        break;
                    }
                }

                if (out_of_guesses)
                {
                    Console.WriteLine("Game over!");
                }
                else
                {
                    Console.WriteLine("You got it right!");
                }
            }

            else if (Stage == "Medium")
            {
                Console.WriteLine("You are playing the Easy Stage");

                int secret_num = 15;
                int guess = 0;
                int guess_count = 0;
                int guess_limit = 4;
                bool out_of_guesses = false;

                while ((guess != secret_num) || (!out_of_guesses))
                {
                    if (guess_count < guess_limit)
                    {
                        Console.WriteLine("Guess a number between 1 and 20: ");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == secret_num)
                        {
                            break;
                        }
                        else if (guess > 20)
                        {
                            Console.WriteLine("Out of guessing range");
                        }
                        ++guess_count;
                        int guesses = guess_limit - guess_count;
                        Console.WriteLine("That was wrong");
                        Console.WriteLine("You have "  + guesses + " guesses left");
                    }
                    else
                    {
                        out_of_guesses = true;
                        break;
                    }
                }

                if (out_of_guesses)
                {
                    Console.WriteLine("Game over!");
                }
                else
                {
                    Console.WriteLine("You got it right!");
                }
            }

            else if (Stage == "Hard")
            {
                Console.WriteLine("You are playing the Easy Stage");

                int secret_num = 37;
                int guess = 0;
                int guess_count = 0;
                int guess_limit = 3;
                bool out_of_guesses = false;

                while ((guess != secret_num) || (!out_of_guesses))
                {
                    if (guess_count < guess_limit)
                    {
                        Console.WriteLine("Guess a number between 1 and 50: ");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == secret_num)
                        {
                            break;
                        }
                        else if (guess > 50)
                        {
                            Console.WriteLine("Out of guessing range");
                        }
                        ++guess_count;
                        int guesses = guess_limit - guess_count;
                        Console.WriteLine("That was wrong");
                        Console.WriteLine("You have "  + guesses + " guesses left");
                    }
                    else
                    {
                        out_of_guesses = true;
                        break;
                    }
                }

                if (out_of_guesses)
                {
                    Console.WriteLine("Game over!");
                }
                else
                {
                    Console.WriteLine("You got it right!");
                }
            }

        }
    }
}
