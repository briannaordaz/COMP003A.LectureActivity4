// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //Section A:
        
        //While Loop: a while loop executes the code if the condition is true 
        int taskNumber = 1;
        while (taskNumber <= 5)
        {
            Console.WriteLine($"Task {taskNumber} completed");
            taskNumber++;
        }
        
          
        
        //Section B:

        int attempt = 1;
        do
        {
            Console.WriteLine($"Attemp {attempt}");
            attempt++;
        }
        while (attempt <= 3);

        
        //Section C:
        
        for (int counter = 1; counter <= 4; counter++)
        {
            Console.WriteLine($"Step {counter}");
        }

        
        //Section D:
        
        int number = 0;
        while (number <= 6)
        {
            number++;
            if (number == 4)
            {
                continue; 
                //if the number equals 4, "continue" will skip the rest of the code 
            }
             if (number == 6)
            {
                break; // the break is used to STOP/exit the loop
            }
             Console.WriteLine(number);
        }

        
        
       
    }
    
}
