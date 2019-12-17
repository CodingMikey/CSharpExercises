using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born?");
            var month = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if(month == "march")
            {
                Console.WriteLine("You are an Aries.");
            }
            else if(month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if(month == "may")
            {
                Console.WriteLine("you are a Gemini");
            }
            Console.ReadLine();
        }

        //Creating a function that returns a value and writes try again if user didn't type anything
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type in anything, please try again:");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
