using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose #");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isRight = number == 9;
            do
         
            {

                switch (number)
                {
                    case 62:
                        Console.WriteLine("not that number, give me other integers");
                        Console.WriteLine("Choose #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("29? Really?? not that number, give me other integers");
                        Console.WriteLine("Choose #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("nooO not 55, give me other integers");
                        Console.WriteLine("Choose #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("NICE That is GREAT #");
                        isRight = true;
                        break;
                    default:
                        Console.WriteLine("Thats Not Right! Something is WRONG!");
                        Console.WriteLine("Choose #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!isRight);

           
        }

       }
    };

         