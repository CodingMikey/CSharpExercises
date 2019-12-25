using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new data object
            var data = new Data();

            //Asking for user input then setting the data properties
            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born?");
            data.Month = TryAnswer();

            //Calling the function that was created in Data class to show users info
            data.Display();

            
        }

        //Creating a method that returns a value and writes try again if user didn't type anything
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
