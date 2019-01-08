﻿using System;
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
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped viaackage Express. Have a good day.");
            }


            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int packageLenght = Convert.ToInt32(Console.ReadLine());

            int total = packageWidth + packageHeight + packageLenght; 
             if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");

            }

            else  
            {
                int result = total * packageWeight / 100;
                Console.Write("Your estimated total for shipping this package is:  $"+result );
                Decimal results = Convert.ToInt32(Console.ReadLine());
            }
                
            


            
               
            
            
            
        }
    }
}