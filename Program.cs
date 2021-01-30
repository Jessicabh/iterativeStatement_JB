using System;

namespace iterativeStatement_JB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer values between 1 and 100");
            try
            {
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if((value > 0 ) && (value <= 100))
                {
                    for(int i = 1; i <= value; i++)
                    {
                        Console.WriteLine("You have entered " + value.ToString() + ". This is the current integer value in the loop:" + i.ToString());
                        
                    }
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value between 1 and 100 and try running the program again...");
                Console.ReadKey(true);
            }
        }
    }
}
