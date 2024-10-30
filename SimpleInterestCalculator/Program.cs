using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input principal, rate, and time
            Console.Write("Enter principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of interest: ");
            Double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time (in years): ");
            int time = Convert.ToInt32(Console.ReadLine());

            // Calculate Simple interest
            Double interest = (principal * rate * time) / 100;

            // Output the result
            Console.WriteLine("Simple interest: " + interest);

            Console.ReadLine();

        }
    }
}
