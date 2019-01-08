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
                "geologist",
                "true",
                "bothell",
                "true",
                "3"
            };

            //Score
            int score = 0;

            // Game Introduction
            Console.WriteLine("Welcome to Jason's Quiz");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Press Enter when you're ready to play.");
            Console.ReadLine();

            //Starting The Game
            for (int i = 0; i < questions.Length; i++)
            {
                //Ask question and store answer.
                string inputAnswer = OutputQuestionInputAnswer(questions[i]);

                // Compare userInput to correct answer.
                bool correct = CompareUserInputANDAnswer(answers[i], inputAnswer);

                // Show result of answer.
                DisplayResults(correct, answers[i]);

                // Keep track of score.
                score = score + scoreTracker(correct);
            }

            //Show the users final score.
            Console.WriteLine($"Quiz Complete: You scored {score}/5.");
            if (score > 3)
            {
                Console.WriteLine($"Great Job {name}!!!");
            }
            else
            {
                Console.WriteLine($"Try harder next time {name}!!!");
            }
            Console.ReadLine();
        }
        
        // Question/Answer Method
        static string OutputQuestionInputAnswer(string question)
        {
            // Asks user question
            Console.WriteLine($"-{question}");

            // Saves user input
            try
            {
             string answer = Console.ReadLine().ToLower();
                if (answer.Length == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return answer;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"-{question}");
                string answer = Console.ReadLine().ToLower();
                return answer;
            }
            

            
        }

        // Answer Checker Method
        static bool CompareUserInputANDAnswer(string answer, string userInput)
        {
            //Compare integer input to integer answer

            //Compare string input to string answer
            if (answer == userInput) return true;
            
            return false;
        }

        // Answer Result Method
        static void DisplayResults(bool correct, string answer)
        {
            // If statement checking for correct answer.
            if (correct)
            {
                Console.WriteLine($"Correct! The answer is indeed {answer}!!");
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {answer}");
            }
        }

        // Score Keeper
        static int scoreTracker(bool correctAnswer)
        {
            // If correct add 1 to score
            if (correctAnswer)
            {
                return 1;
            }
            else return 0;
        }

    }
}