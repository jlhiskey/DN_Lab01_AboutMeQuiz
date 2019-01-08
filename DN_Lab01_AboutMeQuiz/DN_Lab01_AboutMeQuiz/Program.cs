using System;

namespace DN_Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jason's Quiz");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Press Enter when your ready to play.");
            Console.ReadLine();         
        }
        
    }
}