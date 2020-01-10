using System;
using System.Collections.Generic;
using System.Text;

namespace Pay
{
    class Paycheck
    {
        public double Stops { get; set; }
        public double Superstops { get; set; }
        public double Miles { get; set; }
        public double Delay { get; set; }
        public double Inspection { get; set; }
        public double Meals { get; set; }
        public double Pallets { get; set; }

        public void Calculate()
        {
            double total =
                (Stops * 18.50) +
                (Superstops * 32) +
                (Miles * 0.49) +
                (Delay * 22) +
                (Inspection * 18.50) +
                (Meals * 25) +
                (Pallets * 1);
            Console.WriteLine($"You made: ${total}");
            Console.Read();
        }
    }
}
