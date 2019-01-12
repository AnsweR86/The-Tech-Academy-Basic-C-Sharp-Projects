using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    //ITERATION ARRAY STRING BY LOOP W/ USER INPUT//
    {
        string[] stArray = new string[5];

        for (int i = 0; i < stArray.Length; i++)
        {
            Console.WriteLine("PLEASE, Insert text to Array string ");
            stArray[i] = Console.ReadLine();
        }

        Console.WriteLine("\nIt shows that you have enter: ");
        for (int i = 0; i < stArray.Length; i++)
        {
            Console.WriteLine(stArray[i]);
        }
        Console.ReadLine();


        //infinite loop //


        ////////////////string[] letaA = { "Agenda", "Apples", "Angus", "Antonio", "Agile" };
        //Console.WriteLine("Please enter the word or name start with letter A: ");
        //string letA = Console.ReadLine();
        //bool done = false;
        //do
        //{
        //    for (int i = 0; i < letaA.Length; i++)
        //    {
        //        if (letA == letaA[i])
        //        {
        //            Console.WriteLine("Your A-Word was found! " + letA);
        //            done = true;
        //        }
        //        Console.WriteLine(letaA[i]);
        //    }
       // }
        //while (!done);



        //Infinite Loop Fix//
        string[] text = { "Agenda", "Apple", "Angus", "Anthony", "Agile" };
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(text[i]);
        }
        Console.WriteLine("\nPlease enter the word or name start with letter A: ");
        string txt = Console.ReadLine();
        Console.WriteLine("\n");
        bool complete = false;
        do
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (txt == text[i])
                {
                    Console.WriteLine(txt + "  Your thing was found!");
                    complete = true;
                }
                else
                {
                    Console.WriteLine(text[i]);
                }

                if (i == text.Length - 1)
                {
                    complete = true;
                }
            }
        }
        while (!complete);

        //Loop that is Less than//
        int[] highScore = { 743, 496, 680, 995, 802, 413, 697, 738, 629 };
        int x = 0;
        do
        {
            Console.WriteLine("Your Highscore, " + highScore[x] + " is Overtaken, Play again.");
            x++;
        }
        while (highScore[x] < 995);
        Console.WriteLine("Your highscore, " + highScore[x] + ", Congratulations, you have set the new HighScore");
        Console.ReadLine();

        //Less Than or Equal Loop//
        int[] testScores = { 25, 98, 75, 87, 66, 97, 68 };
        x = 0;
        do
        {
            Console.WriteLine("Your test score, " + testScores[x] + ", is too low, Study hard next time");
            x++;
        }
        while (testScores[x] <= 75);
        Console.WriteLine("Your test score, " + testScores[x] + "  Congratulations, You have Pass the course!");
        Console.ReadLine();

        
        //ITEM FOUND W/ UNIQUE ARRAY//
       
        List<string> pets = new List<string>() { "cat", "dog", "birds", "Monkey", "hamster", "snake" };

        for (int i = 0; i < pets.Count; i++)
        {
            Console.WriteLine(pets[i]);
        }

        Console.WriteLine("Please enter animal thst is legal to have pet: ");
        string pet = Console.ReadLine();
        Console.WriteLine("\n");
        foreach (string petz in pets)
        {
            if (petz == pet)
            {
                Console.WriteLine(petz + "  Your Correct! ");
            }
            else
            {
                Console.WriteLine(petz);
            }
        }
        Console.ReadLine();

        //NOT FOUND//
        Console.WriteLine("Please enter animal thst is legal to have pet: ");
        pet = Console.ReadLine();
        Console.WriteLine("\n");
        bool found = false;
        foreach (string petz in pets)
        {
            if (petz == pet)
            {
                Console.WriteLine(petz + "  You are Right! ");
                found = true;
            }
            Console.WriteLine(petz);
        }
        if (!found)
        {
            Console.WriteLine("\nNope Nevr will be.");
        };


        //EXITING LOOP IF FOUND//
        Console.WriteLine("Please enter animal thst is legal to have pet: ");
        pet = Console.ReadLine();
        Console.WriteLine("\n");

        foreach (string petz in pets)
        {
            if (petz == pet)
            {
                Console.WriteLine(petz+"Your animal was found!");
                //notFound = false;
                break;
            }
            Console.WriteLine(petz);
        }


        //ITERATE & DISPLAY MATCHING ITEM//
    
        List<string> trafficLights = new List<string>() { "green","yellow","red","amber" };
        for (int i = 0; i < trafficLights.Count; i++)
        {
            Console.WriteLine(trafficLights[i]);
        }

        Console.WriteLine("Name the TrafficLight Colors: ");
        string input = Console.ReadLine();
        Console.WriteLine("\n");
        int m = 0;
        foreach (string trafficLight in trafficLights)
        {
            if (input == trafficLight)
            {
                Console.WriteLine("Found a match at index  " + m);
            }
            Console.WriteLine(trafficLight);
            m++;
        }


        //NOT FOUND MESSAGE//
        Console.WriteLine("Name the TrafficLight Color ");
        input = Console.ReadLine();
        Console.WriteLine("\n");
        m = 0;
        found = false;
        foreach (string trafficLight in trafficLights)
        {
            if (input == trafficLight)
            {
                Console.WriteLine("Found a match at index " + m);
                found = true;
            }
            Console.WriteLine(trafficLight);
            m++;
        }
        if (!found)
        {
            Console.WriteLine("No...You should not Drive today");
        };

        Console.ReadLine();

        //Display Absolute//
        List<string> exoticAnimals = new List<string>() { "Tiger", "Phanther", "Eagle", "Cobra", "Ligar", "Tilon", "Mamoth", "Wolf", "2HeadSnake", "Leopard" };
        int index = 0;
        found = false;
        string[] compareArray = new string[exoticAnimals.Count];
        foreach (string exoticAnimal in exoticAnimals)
        {
            compareArray[index] = exoticAnimal;
            Console.WriteLine(exoticAnimal);
            for (int i = 0; i < index; i++)
            {
                if (compareArray[i] == exoticAnimal && (!found))
                {
                    Console.WriteLine("Item appeared in list: " + exoticAnimal);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Item has not appeared in list: " + exoticAnimal);
            }
            index++;
            found = false;
        }
        Console.ReadLine();

    }
}