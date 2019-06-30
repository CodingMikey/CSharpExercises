using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to print only the odd numbers.

            int[] arr = new int[] { 4, 5, 7, 9, 3 };

            int i = 0;

            for (i = 0; i < arr.Length; i++)
            {
                //condition to check ODD number
                if (arr[i] % 2 != 0)
                    Console.Write(arr[i] + " ");

            }
            Console.ReadLine();
        }
    }
}
