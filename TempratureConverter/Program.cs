using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input temprature in celcius
            Console.WriteLine("Enter temprature in celcius: ");
            Double celcius = Convert.ToDouble(Console.ReadLine());

            // Convert to Farenheit
            Double farenheit = (celcius * 9 / 5) + 32;

            // Output teh result
            Console.WriteLine("Temprature in Farenheit: " + farenheit);

            Console.ReadLine();
        }
    }
}
