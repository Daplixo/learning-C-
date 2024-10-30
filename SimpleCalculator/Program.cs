using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        // Input from user
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Perform the operation
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.Write("Error: Division by zero is not allowed");
                        return; // Exit the program if divison by zero
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return; // Exit the program if operator is invalid
            }
            // Output the result
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}
