using System;

namespace DN_Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questions

            string[] questions = {
                "What was my profession before attending Code Fellows?",
                "True or False: Do I own a dog?",
                "Do I live in Kirkland or Bothell?",
                "True or False: Do I own a truck?",
                "How many states have I lived in? "
            };

            //Answers

            string[] answers = {
                "Geologist",
                "True",
                "Bothell",
                "True",
                "3"
            };

            //Score
            int score = 0;

            // Game Introduction
            Console.WriteLine("Welcome to Jason's Quiz");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Press Enter when your ready to play.");
            Console.ReadLine();         
        }
        
        // Question/Answer Method

        // Answer Checker Method

        // Answer Result Method

        // Score Keeper



    }
}