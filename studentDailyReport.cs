
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("The Tech Academy");
                Console.WriteLine("Student daily Report");

                Console.ReadLine();



                Console.WriteLine("What coursr are you on?");
                string currentCourse = Console.ReadLine();
                Console.WriteLine("Your currently on:" + currentCourse + "course");
                Console.ReadLine();

                Console.WriteLine("What page number?");

                int pageNumber;
                pageNumber = int.Parse(Console.ReadLine());


                Console.WriteLine("Do you need any help with anything? Please answer in'true'or'false'");
                bool helpNeed;
                helpNeed = bool.Parse(Console.ReadLine());
                Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics and Press Enter");
                string positiveExperience = Console.ReadLine();

                Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
                string feedBack = Console.ReadLine();
                Console.ReadLine();

                Console.WriteLine("How many hour did you study today?");
                string studyHour = Console.ReadLine();
                int NumOfHrStudy = Convert.ToByte(studyHour);
                Console.WriteLine("Tody you have studied" + NumOfHrStudy + "hours");
                Console.ReadLine();

                Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
                Console.ReadLine();



            }
        }
    }


