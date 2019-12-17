using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count from 1 to 10 then back to 1
            //and repeat this loop five times

            for (int x = 0; x <= 5; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
