// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //Section A: While Loop
        
        //While Loop: a while loop executes the code if the condition is true 
        int taskNumber = 1;
        while (taskNumber <= 5)
        {
            Console.WriteLine($"Task {taskNumber} completed");
            taskNumber++;
        }
        
          
        
        //Section B: Do-While Loop

        /*
         *This loop executes at least once because the body loop runs first and then the condition is checked after
         */
        int attempt = 1;
        do
        {
            Console.WriteLine($"Attemp {attempt}");
            attempt++;
        }
        while (attempt <= 3);

        
        //Section C: For Loop
        
        //A for loop is appropriate for this task because we want the console to execute the code a certain number of times and the for loop allows us to do that, it's also easier than doing a while or do-while loop 
      
        for (int counter = 1; counter <= 4; counter++)
        {
            Console.WriteLine($"Step {counter}");
        }

        
        //Section D: Loop Control (break and continue)
        
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

        
        
        //Section E:
        
        /*
           Which loop type was easiest for you to understand?
           I think the easiest type of loop for me to understand was the first while loop because all we had to do 
           was declare and initialize a variable, type the condition, and then the body of the loop

           Which loop required the most careful tracing?
            The while loop Section D required the most careful tracing because were not only typing the condition
             and the body of loop but were also typing two if statements and adding "continue" or "break" depending
             on what the number is

           How did comments help you understand your loops?
           The comments helped me understand my loop because it gave me some information about what each do
           and also if I ever forget what each loop does, I can always come back and read the comments

         */
    }
    
}
