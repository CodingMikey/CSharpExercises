using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public static class ExtensionMethods
    {
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
    class Console
    {
        //This is a utility class. Creating an ASK method below
        static public string Ask(string question)
        {
            //Since we changed the namespace we hae to enter System to access some features below
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        //Overloading the method above 
        static public string Ask(double question)
        {
            //Since we changed the namespace we have to enter System to access some features below
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        //Creating an ASK method that parses a string into a integer 
        static public double AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return System.Console.ReadLine().toInt();
            }
            catch (Exception)
            {

                throw new FormatException("Input was not a number");
            }
        }
    }
}
