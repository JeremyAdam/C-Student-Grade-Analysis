using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class studentGrades {
        static void Main(string[] agrs)
        {
            Random random = new Random(); // Helps Create The Random Int
            List<int> gradesList = new List<int>(); // Creates List
            int select = 0; // For Selcting Things From Menu
            bool menuOpen = true; // For Loading The Main Menu
            bool run = true; // For Running The Program
            for (int i = 0; i < 50; i++) // Generates 50 Random Grades
            {
                int randNum = random.Next(0, 100);
                gradesList.Add(randNum);
            }
            while (run == true)
            { // Runs Program
                while (menuOpen == true)
                { // Creates The Main Menu
                    Console.WriteLine(" ");                
                    Console.WriteLine("STUDENT GRADES");
                    Console.WriteLine("  1: Display All Grades.");
                    Console.WriteLine("  2: Randomize Grades.");
                    Console.WriteLine("  3: Stats.");
                    Console.WriteLine("  4: Count Honours.");
                    Console.WriteLine("  5: Exit");
                    Console.WriteLine("SELECT (1-5): ");
                    select = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");      
                    menuOpen = false;
                }
                if (select == 1)
                { // Display All Grades
                    foreach (int a in gradesList)
                    {
                        Console.WriteLine(a);
                    }
                    select = 0;
                    menuOpen = true;
                } else if (select == 2)
                { // Randomize Grades
                    gradesList.Clear();
                    for (int i = 0; i < 50; i++)
                    {
                        int randNum = random.Next(0, 100);
                        gradesList.Add(randNum);
                    }
                    Console.WriteLine("Grades randomized");
                    select = 0;
                    menuOpen = true;
                } else if (select == 3)
                { // Generate General Statistics
                    int [] gradesArray = gradesList.ToArray();
                    Console.WriteLine("The highest grade was: " + gradesArray.Max());
                    Console.WriteLine("The lowest grade was: " + gradesArray.Min());
                    Console.WriteLine("The average grade was: " + gradesArray.Sum() / gradesArray.Length);                    
                    select = 0;
                    menuOpen = true;
                } else if (select == 4)
                { // Show All Honour Grades
                    int honourAmount = 0;
                    for (int i = 0; i < gradesList.Count; i++)
                    {
                        if (gradesList[i] >= 80) 
                        {
                            Console.WriteLine(gradesList[i]);
                            honourAmount++;
                        }
                    }
                    Console.WriteLine("There were ( " + Convert.ToString(honourAmount) + " ) honour students.");
                    select = 0;
                    menuOpen = true;
                } else if (select == 5)
                { // End Program
                    run = false;
                } else
                {
                    Console.WriteLine("Value does not work");
                    select = 0;
                    menuOpen = true;
                }
            } 
        }
    }
}
