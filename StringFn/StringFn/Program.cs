using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFn
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Jinho";
            string lName = "Chang";
            string date = DateTime.Today.ToShortDateString();


            //Concatenate 3 Strings
            //// Use the + and += operators for one-time concatenations.
            //string str = "Hello " + fName + lName + ". Today is " + date + ".";
            
            //UPPER CASE
            //str = str.ToUpper();

            //Stringbuilder Paragraph
            StringBuilder sb = new StringBuilder();
            sb.Append("\t My name is JinhoChang and today is " + date + "\n its Very Nice outside today.\n We Should all go out side and play sports! \n It will be Very FUN!!");



            System.Console.WriteLine(sb);
            Console.ReadLine();
        }
       
    }
}
