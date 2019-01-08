using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define questions and answers
            string[] questions = {
                "How old was I when I got my driver's license?",
                "T or F: I can wiggle my ears.",
                "T or F: I like cats more than dogs.",
                "What is the last name of my favorite author?",
                "T or F:I've had two different legal names. "
            };

            string[] answers = {
                "16",
                "false",
                "true",
                "nabokov",
                "true"
            };

            //For tallying the user score
            int score = 0;

            //Welcome the user
            Console.WriteLine("Welcome to my About Me Quiz! There are 5 questions. Let's get started!\n\n");

            //Start quiz
            for (int i = 0; i < questions.Length; i++)
            {
                //Ask question, get answer, and check answer
                string userAnswer = AskQuestionGetAnswer(questions[i]);
                bool correct = CheckAnswer(answers[i], userAnswer);

                //Display correct answer and update score
                DisplayResult(correct, answers[i]);
                score += UpdateScore(correct);
            }

            //Display total score to user
            Console.WriteLine($"Quiz over: You scored {score}/5.");

        }


        //Asks the given question and returns the user's answer
        static string AskQuestionGetAnswer(string question)
        {
            //Ask question
            Console.WriteLine($"--> {question}");

            //Get answer
            string answer = Console.ReadLine().ToLower();

            //Add newline
            Console.WriteLine();

            return answer;
        }


        //Checks the user's answer against the real answer. Returns true if
        //there's a match, otherwise returns false
        static bool CheckAnswer(string answer, string userInput)
        {
            //Check for straightforward answers (e.g. numbers)
            if (answer == userInput) return true;

            //Check for string answers
            else if (string.Compare(answer, userInput) == 0) return true;

            //Check for bool answers
            else if (answer[0] == userInput[0] && (userInput[0] == 't' || userInput[0] == 'f')) return true;

            return false;
        }


        //Displays right or wrong, and the correct answer
        static void DisplayResult(bool correct, string answer)
        {
            if (correct)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {answer}");
            }

            //Add newline before next question
            Console.WriteLine();
        }

        //Determines whether another point should be added
        //and returns the new, updated score
        static int UpdateScore(bool correctAnswer)
        {
            if (correctAnswer)
            {
                return 1;
            }
            else return 0;
        }
    }


}