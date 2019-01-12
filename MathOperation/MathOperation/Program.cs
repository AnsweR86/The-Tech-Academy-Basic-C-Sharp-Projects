using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a Number for multiply Opeation");
            double Multiply = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Multiply * 50);

            Console.WriteLine("Enter a number for addition!");
            int Addtion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Addtion+ 25);

            Console.WriteLine("Enter Number for Dividion!");
            float Division = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Division/ 12.5);

            Console.WriteLine("Enter your Number to see if its greater my number");
            int Comparison = Convert.ToInt32(Console.ReadLine());
            bool isGreater = Comparison > 50;
            Console.WriteLine(isGreater.ToString());

            Console.WriteLine(" Enter a number for Mod. Operation");
            int ModOp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ModOp % 7);
            Console.ReadLine();



        }
    }

}
