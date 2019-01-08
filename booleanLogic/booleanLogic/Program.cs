using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("How old are you?");
            string age=Console.ReadLine();
            int currentAge = Convert.ToInt32(age);
            

            Console.WriteLine("Have you ever had DUI? True or False");
            bool hadDUI =  (false == true) ;
           
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket =Console.ReadLine();
            int ticketCount = Convert.ToInt32(ticket);

            bool Qualified = (currentAge > 15 && hadDUI == false && ticketCount <= 3);
            string qualification =Convert.ToString(Qualified);
            
            if (true)
            {
                Console.WriteLine("your Qualified");
            }
            Console.ReadLine();

            

        }
    }
}
