using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class Console
    {
        //This is a utility class used for asking questions
        static public string Ask(string question)
        {
            //Since we changed the namespace we hae to enter System to access some features below
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}
