using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Given an array of integers, write a method to total the odd numbers.

            //Creating a random array here that is hardcoded
            int[] arr = { 3, 15, 2, 8, 19 };

            //Creating a varible that can store the sum total
            int odd = 0;

            //Creating "i" variable to scan the array
            for (int i = 0; i < arr.Length; i++)
            {
                //This is what checks if the integer is an odd number using modulus
                if (arr[i] % 2 != 0)
                {
                    //Here we are adding the odd numbers together and storing the sum value into odd
                    odd = odd + arr[i];
                }
            }

            Console.WriteLine(odd);
            Console.ReadLine();
        }
    }
}
