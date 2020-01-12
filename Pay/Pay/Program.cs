using System;


namespace Pay
{
    class Program
    {
        static void Main(string[] args)
        {

            Paycheck paycheck = new Paycheck
            {
                
                Stops = Util.Console.AskInt("Stops: "),
                Superstops = Util.Console.AskInt("Superstops: "),
                Miles = Util.Console.AskInt("Miles: "),
                Delay = Util.Console.AskInt("Delay: "),
                Inspection = Util.Console.AskInt("Inspections: "),
                Meals = Util.Console.AskInt("Meals: "),
                Pallets = Util.Console.AskInt("Pallets: "),
                Layover = Util.Console.AskInt("Layovers: ")
            };
             paycheck.Calculate();
        }
    }
}
