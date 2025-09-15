using System.Net.Quic;

namespace BetterCalculator
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Better Calculator Program
    //https://github.com/micahspencer-png/BetterCalculator.git
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            bool proceed1 = false;
            bool proceed2 = false;
            bool proceed3 = false;
            string userInput;
            int firstNumber;
            int secondNumber;
            int calc;

            while (quit == false)
            {
                Console.WriteLine("Please Enter 2 Whole Numbers. Type Q to quit at any time");

                do
                {
                    Console.WriteLine("Enter First Number");
                    userInput = Console.ReadLine(); 
                    firstNumber = int.Parse(userInput);
                    proceed3 = false;
                    try
                    {
                        Console.WriteLine($"You Have Entered: {userInput}");
                        firstNumber = int.Parse(userInput);
                        proceed1 = true;
                    }
                    catch
                    {
                        if (userInput == "Q")
                        {
                            quit = true;
                            

                        }
                        else
                        {
                            Console.WriteLine($"{userInput} Isn't a Whole Number");
                        }
                    }
                    

                } while (proceed1 == false);

                do
                {
                    Console.WriteLine("Enter Second Number");
                    userInput = Console.ReadLine();
                    secondNumber = int.Parse(userInput);
                    try
                    {
                        Console.WriteLine($"You Have Entered: {userInput}");
                        
                        proceed2 = true;
                    }
                    catch
                    {
                        if (userInput == "Q")
                        {
                            quit = true;
                            proceed1 = true;
                            proceed2 = true;
                            proceed3 = true;
                            
                        }
                        else
                        {
                            Console.WriteLine($"{userInput} Isn't a Whole Number");
                        }secondNumber = int.Parse(userInput);
                    }
                } while (proceed2 == false);

                do
                {
                    Console.WriteLine("Pick an Operation");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    userInput = Console.ReadLine();
                    int result1 = firstNumber + secondNumber;
                    int result2 = firstNumber - secondNumber;
                    int result3 = firstNumber * secondNumber;
                    int result4 = firstNumber / secondNumber;
                    try
                    {
                        Console.WriteLine($"You Have Entered: {userInput}");
                        calc = int.Parse(userInput);
                        if (calc == 1)
                        {
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {result1}");
                            proceed3 = true;
                        }
                        else if (calc == 2)
                        {
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {result2}");
                            proceed3 = true;
                        }
                        else if (calc == 3)
                        {
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {result3}");
                            proceed3 = true;
                        }
                        else if (calc == 4)
                        {
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {result4}");
                            proceed3 = true;
                        }
                        proceed1 = true;

                    }
                    catch
                    {
                        if (userInput == "Q")
                        {
                            quit = true;
                            proceed1 = true;
                            proceed2 = true;
                            proceed3 = true;
                        }
                        else
                        {
                            Console.WriteLine($"{userInput} Isn't a Whole Number");
                        }
                    }
                } while (proceed3 == false);

            }
            
            
                Console.WriteLine("Have a Great Day.");
                Console.WriteLine("Press Enter to Quit Program");
                Console.Read();
            
        }
    }
}
