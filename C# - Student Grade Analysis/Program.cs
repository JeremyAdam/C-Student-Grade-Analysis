using System;
using System.Collections.Generic;
using System.Linq;
class studentGrades {
    static void Main()
    {
        // Program Variables
        Random random = new Random(); // Helps Create The Random Int
        List<int> gradesList = new List<int>(); // Creates List
        int select = 0; // For Selcting Things From Menu
        bool run = true; // For Running The Program
        
        // Generates 50 Random Grades
        for (int i = 0; i < 50; i++)
        {
            int randNum = random.Next(0, 100);
            gradesList.Add(randNum);
        }

        // Main Loop
        while (run == true)
        {
            // Creates The Main Menu
            Console.WriteLine(" ");                
            Console.WriteLine("STUDENT GRADES");
            Console.WriteLine("  1: Display All Grades.");
            Console.WriteLine("  2: Randomize Grades.");
            Console.WriteLine("  3: Stats.");
            Console.WriteLine("  4: Count Honours.");
            Console.WriteLine("  5: Exit");
            Console.Write("SELECT (1-5): ");
            select = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");      
            switch(select)
            {
                case 1: // Display All Grades
                    foreach (int grade in gradesList)
                    {
                        Console.WriteLine(grade);
                    }
                    select = 0;                    
                    break;
                 case 2: // Randomize Grades
                    gradesList.Clear();
                    for (int i = 0; i < 50; i++)
                    {
                        int randNum = random.Next(0, 100);
                        gradesList.Add(randNum);
                    }
                    Console.WriteLine("Grades randomized");
                    select = 0;                
                    break;
                case 3: // Generate General Statistics
                    int [] gradesArray = gradesList.ToArray();
                    Console.WriteLine("The highest grade was: " + gradesArray.Max());
                    Console.WriteLine("The lowest grade was: " + gradesArray.Min());
                    Console.WriteLine("The average grade was: " + gradesArray.Sum() / gradesArray.Length);                    
                    select = 0;                    
                    break;
                case 4: // Show All Honour Grades
                    int honourAmount = 0;
                    for (int i = 0; i < gradesList.Count; i++)
                    {
                        if (gradesList[i] >= 80) 
                        {
                            Console.WriteLine(gradesList[i]);
                            honourAmount++;
                        }
                    }
                    Console.WriteLine("There were (" + Convert.ToString(honourAmount) + ") honour students.");
                    select = 0;
                    break;
                case 5: // End Program
                    run = false;                
                    break;
                default:
                    Console.WriteLine("Value does not work");
                    select = 0;                
                    break;
            }
        } 
    }
}
