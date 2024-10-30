using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take input from user
            Console.WriteLine("Enter area of Circle: ");
            Double radius = Convert.ToDouble(Console.ReadLine());

            // Calculate the area
            Double area = Math.PI * radius * radius;

            // Output the result

            Console.WriteLine("Area of circle is:" + area);

            Console.ReadLine();

        }
    }
}
