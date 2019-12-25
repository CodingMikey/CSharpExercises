using System;
using System.Collections.Generic;
using System.Text;

namespace Survey
{
    class Data
    {
        //Setting the properties for our data class
        public string Name;
        public int Age;
        public string Month;

        //Creating a function to display users info
        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);

            if (Month == "july")
            {
                Console.WriteLine("You are a Cancer.");
            }
            else if (Month == "april")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if (Month == "may")
            {
                Console.WriteLine("You are a Gemini.");
            }
        }
    }
}
