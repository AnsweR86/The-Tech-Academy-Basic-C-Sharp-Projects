using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathNcomparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product(Multiply)
            Console.WriteLine("Please, enter a Number");
            string num1 = Console.ReadLine();
            int givenNumber = Convert.ToInt32(num1);
            int product = givenNumber * 50;
            Console.WriteLine("your number mutltiply 50 =" + product);
            Console.ReadLine();

            //Addition
            Console.WriteLine("Please, enter a Number");
            string num2 = Console.ReadLine();
            int givenNumber2 = Convert.ToInt32(num2);
            int addition = givenNumber2 + 25;
            Console.WriteLine("your number plus 25 =" + addition);
            Console.ReadLine();


            //Division
            Console.WriteLine("Please, enter a Number");
            string num3 = Console.ReadLine();
            int givenNumber3 = Convert.ToInt32(num3);
            double quotient = givenNumber3/ 12.5;
            Console.WriteLine("your number divied 50 =" + quotient);
            Console.ReadLine();


            //Comparison if its Greater than 50
            Console.WriteLine("Enter Number and see its Greater than Mystry Number");
            string isGreater = Console.ReadLine();
            int valueIn = Convert.ToInt32(isGreater);
            bool trueOrFalse = valueIn > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            //MOD
            Console.WriteLine("Please, enter a Number");
            String num4 = Console.ReadLine();
            int givenNumber4 = Convert.ToInt32(num4);
            int remainder = givenNumber4 % 7;
            Console.WriteLine("you have remainder value of" + remainder + "left");
            Console.ReadLine();
        }
    }
}
