using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]stArray = new string[] { "RED", "BLUE", "PURPLE", "GREEN" };
            Console.WriteLine("What is your Favorite Color?");
            int stResult = Convert.ToInt16(Console.ReadLine());

            bool stAnswer = false;

            for (int i = 0; i < stArray.Length; i++)
            {
                if (stResult == i)
                {
                    stAnswer = true;
                    Console.WriteLine(stArray[stResult]);
                }

            }

            if (stAnswer == false)
            {
                Console.WriteLine("Sorry, that is not a valid index.");
            }

           
          

            

            int[] numArray = {0,6,9,14,56 };
            Console.WriteLine("Please Enter the index of the number .");
            int numResult = Convert.ToInt16(Console.ReadLine());

            bool numAnswer = false;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numResult== i)
                {
                    numAnswer = true;
                    Console.WriteLine(numArray[numResult]);
                }

            }

            if (numAnswer == false)
            {
                Console.WriteLine("Sorry, that is not a valid index.");
            }



            List<string> strList = new List<string>();
            strList.Add("Mustang");
            strList.Add("Charger");
            strList.Add("Challenger");
            strList.Add("Viper");
            strList.Add("Corvette");
            Console.WriteLine("Please select the index of the American Car you'd like.");
            int listResult = Convert.ToInt16(Console.ReadLine());

            bool listAnswer = false;

            for (int i = 0; i < strList.Capacity; i++)
            {
                if (listResult == i)
                {
                    listAnswer = true;
                    Console.WriteLine(strList[listResult]);
                }

            }

            if (listAnswer == false)
            {
                Console.WriteLine("Sorry, that is not a valid index.");
            }

            Console.ReadLine();
        }
    }