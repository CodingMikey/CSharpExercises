using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";

            while (code != "secret")
            {
                Console.WriteLine("Enter the password:");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("Not Authenticated");
                }
            }
            Console.WriteLine("Authenticated!");
            Console.ReadLine();
        }
    }
}
