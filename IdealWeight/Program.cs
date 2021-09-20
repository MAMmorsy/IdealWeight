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
            Gender='f'};
            double weight = wegihtcalc.GetIdealBodyWeight();
            Console.WriteLine($"The ideal weight is {weight}");
            Console.ReadKey();
        }
    }
}
