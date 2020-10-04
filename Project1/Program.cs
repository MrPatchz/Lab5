using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            int num = random.Next(0,100);
            int guess = 0;
            do
            {
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
                    Console.WriteLine("You guessed Correct! Good Job!");
                }
            } while (guess != num);

        }
    }
}
