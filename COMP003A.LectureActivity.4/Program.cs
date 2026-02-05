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
        

    }
    
}
