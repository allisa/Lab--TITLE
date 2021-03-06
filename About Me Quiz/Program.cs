﻿using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please take a quiz about me!");

            Console.WriteLine("What state am I from?");
            string questionOne = Console.ReadLine();
            Console.WriteLine($"You answered {questionOne}. Your answer is: {QuestionOne(questionOne)}");

            Console.WriteLine("Guess the day of my birth");
            int questionTwo = int.Parse(Console.ReadLine());
            QuestionTwo(questionTwo);

            Console.WriteLine("True or false: I have a Costco membership");
            bool questionThree = bool.Parse(Console.ReadLine());
            QuestionThree(questionThree);

            Console.WriteLine("Do I like cats or dogs?");
            string questionFour = Console.ReadLine();
            Console.WriteLine($"You answered {questionFour}. The answer is: {QuestionFour(questionFour)}");

            Console.WriteLine("Do I have a tattoo?");
            string questionFive = (Console.ReadLine());
            QuestionFive(questionFive);
            Console.WriteLine($"You answered {questionFive}. Your answer is: {QuestionFive(questionFive)}");

        }
        //Question 1: Method to check users input with an if statement
        static string QuestionOne(string input)
        {
            if (input == "CO" || input == "Colorado")
            {
                return "Correct";
            }
            else
                return "Incorrect";
        }

        //Question 2: Method to check if user's integar input is correct, I don't understand how to return and intergar any other way than this
        static int QuestionTwo(int numInput)
        {
            if (numInput == 29)
            {
                Console.WriteLine("Your answer is correct.");
                return 29;
            }
            else
            {
                Console.WriteLine($"That is incorrect. You are {29 - numInput} days off");
                return 29 - numInput;
            }
        }

        //Question 3: Method to return boolean.
        static bool QuestionThree(bool boolean)
        {
            if (boolean == false)
            {
                Console.WriteLine("answered false. Your answer is: Correct");
                return false;
            }
            else
            {
                Console.WriteLine("answered true. Your answer is: Incorrect");
                return true;
            }
        }
        
        //Question 4: Method to check user's string input, return correct or incorrect based on input
        static string QuestionFour(string input)
        {
            if (input == "dogs")
            {
                return "Correct, my dog is the best";
            }
            else
            {
                return "Incorrect";
            }
        }
        
        //Question 5: Method to check user's string input. I realize this does not account for the user
        //entering something other than "Yes"
        static string QuestionFive( string input)
        {
            if (input == "Yes")
            {
                return "Incorrect";
            }
            else
            {
                return "Correct";
            }
        }
    }
}
