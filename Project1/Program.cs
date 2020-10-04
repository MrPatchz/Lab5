using System;
using System.Collections.Specialized;
using System.Threading;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            System.Random random = new System.Random();
            int num = random.Next(0,100);
            int guess = 0;
            do
            {
                count++;
                Console.Write("Please guess a number: ");
                guess = int.Parse(Console.ReadLine());
                if (guess < num)
                {
                    Console.WriteLine("You guessed too Low.");
                }
                else if (guess > num)
                {
                    Console.WriteLine("You guessed too High.");
                }
                else
                {
                    Console.WriteLine("You guessed Correct! Good Job! It took you " + count + " guesses"); ;
                }
            } while (guess != num);

        }
    }
}
