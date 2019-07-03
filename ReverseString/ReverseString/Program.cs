using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge: Given a string, reverse it.

            string name = "Tesla";
            char[] rs = name.ToArray();
            Array.Reverse(rs);
            Console.WriteLine(rs);
            Console.ReadLine();
        }
    }
}
