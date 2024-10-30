using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "27";
            int age = Convert.ToInt32(textAge);

            Console.WriteLine(age);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            string textBig = "200000000";
            long bignumber = Convert.ToInt64(textBig);

            Console.WriteLine(bignumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            string textNegative = "-11.11";
            double negative = Convert.ToDouble(textNegative);

            Console.WriteLine(negative);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            string textPrec = "4.000000023";
            float prec = Convert.ToSingle(textPrec);

            Console.WriteLine(prec);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            string textMoney = "16.99";
            decimal money = Convert.ToDecimal(textMoney);

            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            string name = "Nishi";
            char letter = 'N';
            Console.WriteLine("Your name is: ");
            Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine(letter);

            bool value = true;
            bool isMale = true;

            int Age = 22;

            Age++;
            Age = Age + 1;
            Age += 1;
            Console.WriteLine(Age);
            Age--;
            Age = Age - 1;
            Age -= 1;
            Console.WriteLine(Age);
            // It is best to division with double data type.

            string str = "Nishi";
            Console.WriteLine(str);

            // We can only add two strings

            str += " I love you!";
            Console.WriteLine(str);

            int i = 0;
            Console.WriteLine(++i);

            int firstNum = 22, secondNum = 4;
            Console.WriteLine(firstNum % secondNum);

            var Num = 24;
            var bigNum = 24000000L;
            var neg = 33.33D;
            var mone = 14.99M;
            var preci = 6.0000000345F;
            var lett = 'A';
            var Gf = "Nishika Sharma";

            Console.WriteLine(Num);
            Console.WriteLine(bigNum);
            Console.WriteLine(neg);
            Console.WriteLine(mone);
            Console.WriteLine(preci);
            Console.WriteLine(lett);
            Console.WriteLine(Gf);
            Console.WriteLine("Thank You");

            // Using Var too often can not be good for the readability of your code.

            const int vat = 20;
            int balance = 1000;
            Console.WriteLine(balance * (vat / 100d) );

            string Name;
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine(Name);

            Console.ReadLine();

        }
    }
}
