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

            //Starting The Game
            for (int i = 0; i < questions.Length; i++)
            {
                //Ask question and store answer.
                string userInput = OutputQuestionInputAnswer(questions[i]);
               
            }

            //Display total score to user
            Console.WriteLine($"Quiz over: You scored {score}/5.");
        }
        
        // Question/Answer Method
        static string OutputQuestionInputAnswer(string question)
        {
            // Asks user question
            Console.WriteLine($"--> {question}");

            // Saves user input
            string answer = Console.ReadLine().ToLower();

            return answer;
        }

        //// Answer Checker Method
        //static string CompareUserInputANDAnswer(string answer, string userInput)
        //{
        //    //Compare integer input to integer answer

        //    //Compare string input to string answer

        //    //Compare boolean input to boolean answer

        //}

        //// Answer Result Method
        //static void DisplayResults(bool correct, string answer)
        //{
        //    // If statement checking for correct answer.
        //}

        //// Score Keeper
        //static int scoreTracker(bool correctAnswer)
        //{
        //    // If correct add 1 to score
        //}

    }
}