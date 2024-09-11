using System;

namespace Times_Table
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true) 
            {
                int startNumber = GetIntInput("Please give a start number");
                int endNumber = GetIntInput("Please give an end number");
                int multiplyer = GetIntInput("what times table would you like to see");
                if (startNumber > endNumber) 
                {
                    Console.WriteLine("Your start number and end number are swapped around!!");
                }
                else if(endNumber > startNumber) 
                {
                    for (int x = startNumber; x <= endNumber; x++) {
                        int multiplication = x * multiplyer;
                        Console.WriteLine(multiplication);
                        
                    }
                    break;
                   
                }
            }
            Console.ReadLine();
        }

        static int GetIntInput(string inputMessage)
        {
            while (true)
            {
                try 
                {
                    Console.WriteLine($"{inputMessage}");
                    var rawInput = int.Parse(Console.ReadLine());
                    return rawInput;

                }
                catch (FormatException)
                {
                    Console.WriteLine("You have given an invalid input");
                }
            }
        }
        
        
        //input module
        //enter start point
        //enter end point
        //print times table
    }
}
