using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {
        //This is a utility class. Creating an ASK method below
        static public string Ask(string question)
        {
            //Since we changed the namespace we hae to enter System to access some features below
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        //Creating an ASK method that parses a string into a integer 
        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {

                throw new FormatException("Input was not a number");
            }
        }
    }
}
