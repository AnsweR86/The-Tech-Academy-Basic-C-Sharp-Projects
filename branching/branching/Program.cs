using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");

            var packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            Console.WriteLine("Please enter the package width:");
            string packageWidth = Console.ReadLine();
            Console.WriteLine("Please enter the package height:");
            string packageHeight = Console.ReadLine();
            Console.WriteLine("Please enter the package length:");
            string packageLenght = Console.ReadLine();

            float total = (Convert.ToInt32(packageWidth) + Convert.ToInt32(packageHeight) + Convert.ToInt32(packageLenght));
            float amount = (total * weight / 100);
            if (total > 50)

            {
                Console.WriteLine("Package too big to be shipped via Package Express.");

            }

            else
            {

                Console.Write("Your estimated total for shipping this package is:  $" + amount.ToString("0.00") + Environment.NewLine+ "Thank You. Come again!");

            }

            Console.ReadLine();
        }
    }
}


        
               
            
            