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


            //Concatenate 3 Strings
            // Use the + and += operators for one-time concatenations.
            string strConcat = "\" Hello ! to  the World! \n Hope Everyone had good \n holidays.\n";
            string strConcat2 = "Hope on 2019,\n we all be Healty and Happy\n and full with Joy\n";

            Console.WriteLine(strConcat + strConcat2);
            
            
           //UPPER CASE
            string strConcat3 = "Knowledge is matter of winning or losing\n Wisdom is matter of \n life and death.";
            Console.WriteLine(strConcat3.ToUpper());

            //Stringbuilder Paragraph
            StringBuilder sb = new StringBuilder();
            sb.Append("\t Hey wanna hear joke?");
            sb.Append("\n she said \"Knock! Knock!\" then I said\" Whose is there?");
            sb.Append("  \nBirtney Spears!\" said from her.");
            sb.Append("  \"Birtney Spears who?\" I asked.");
            sb.Append("\n she said\"Oops I did it agian\" then we laugh at loud. ");
                


               Console.WriteLine(sb);
               Console.ReadLine();
        }
       
    }
}
