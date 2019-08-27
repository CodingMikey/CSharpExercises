using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp, revNum = 0, rem;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num; 
            while (num > 0)
            {
                rem = num % 10; 
                revNum = revNum * 10 + rem; 
                num = num / 10; 
            }
            if (revNum == temp)
                Console.WriteLine("Number is a Palindrome.");
            else
                Console.WriteLine("Number is not Palindome.");

            Console.ReadLine();
        }
    }
}
