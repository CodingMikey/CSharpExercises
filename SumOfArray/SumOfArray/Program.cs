using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.

            int[] nums = { 255, 505, 25, 111};
            int sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadLine();

            /* Getting SUM of array using LINQ 

            int[] arr = { 44, 575, 433, 22 };

            int sum = arr.Sum();

            Console.WriteLine(sum);
            Console.ReadLine();

            */
        }
    }
}
