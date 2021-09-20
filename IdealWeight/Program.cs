using System;

namespace IdealWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            WeightCalculator wegihtcalc = new WeightCalculator
            { Height=180,
            Gender='m'};
            double weight = wegihtcalc.GetIdealBodyWeight();
            Console.WriteLine($"The ideal weight is {weight}");
            if(weight==72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!");
            }
            wegihtcalc.Gender = 'f';
            weight = wegihtcalc.GetIdealBodyWeight();
            Console.WriteLine($"The ideal weight is {weight}");
            if (weight == 72.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!");
            }

            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
