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
            //sets variables
            bool quit = false;
            bool proceed1 = false;
            bool proceed2 = false;
            bool proceed3 = false;
            string userInput;
            int firstNumber;
            int secondNumber;
            int calc;

            //sets a loop to continuethe process
            while (quit == false)
            {
                //prompts user and lets them know how to exit
                Console.WriteLine("Please Enter 2 Whole Numbers. Type Q to quit at any time");

                do
                {
                   
                    //shows the user the number and runs it through a process
                    Console.WriteLine("Enter First Number");
                    userInput = Console.ReadLine(); 
                    Console.WriteLine($"You Have Entered: {userInput}");
                   
                    //runs the number if it works
                    try
                    {

                        firstNumber = int.Parse(userInput);
                        proceed1 = true;
                    }
                   
                    //prompts the user to try again
                    catch
                    {
                       
                        //sets the quit function up
                        if (userInput == "Q")
                        {
                            quit = true;
                            proceed1 = true;
                        
                        }
                        
                        //resets this part of the loop if wrong
                        else
                        {
                            Console.WriteLine($"{userInput} Isn't a Whole Number");
                            proceed1 = false;
                            firstNumber = 0;
                        }
                    }

                } while (proceed1 == false);
               
                // breaks the entire loop and closes the program, or continues to the next part and stores data
                if (userInput == "Q")
                {
                    break;
                    
                }
                else
                {
                    firstNumber = int.Parse(userInput);
                }
               
                //prompts user for second number
                do
                {
                    Console.WriteLine("Enter Second Number");
                    userInput = Console.ReadLine();
                    Console.WriteLine($"You Have Entered: {userInput}");
                    
                    //runs code if it is number
                    try
                    {

                        secondNumber = int.Parse(userInput);
                        proceed2 = true;
                    }
                    
                    //sets up quit function or loop condition
                    catch
                    {
                        if (userInput == "Q")
                        {
                            quit = true;
                            proceed1 = true;
                            proceed2 = true;
                            proceed3 = true;
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine($"{userInput} Isn't a Whole Number");
                            proceed2 = false;

                        }
                    }
                } while (proceed2 == false);
               
                //breaks the loop or stores the second number and continues the program
                if (userInput == "Q")
                {
        
                    secondNumber = 1;
                    break;
                }
                else
                {
                    secondNumber = int.Parse(userInput);
                }

                //sets up the math functions of the program
                do
                {
                    Console.WriteLine("Pick an Operation");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    userInput = Console.ReadLine();
                   
                    //sets variables for the functions
                    int result1 = firstNumber + secondNumber;
                    int result2 = firstNumber - secondNumber;
                    int result3 = firstNumber * secondNumber;
                    int result4 = firstNumber / secondNumber;
                    try
                    {
                        Console.WriteLine($"You Have Entered: {userInput}");
                        calc = int.Parse(userInput);
                       
                        //sets add
                        if (calc == 1)
                        {
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {result1}");
                            proceed3 = true;
                        }
                       
                        //sets subtract
                        else if (calc == 2)
                        {
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {result2}");
                            proceed3 = true;
                        }
                       
                        //sets multiply
                        else if (calc == 3)
                        {
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {result3}");
                            proceed3 = true;
                        }
                      
                        //sets divide
                        else if (calc == 4)
                        {
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {result4}");
                            proceed3 = true;
                        }
                        proceed1 = true;

                    }
                   
                    //sets up to either break loop or reprompt function
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
                            proceed3 = false;
                        }
                    }
                } while (proceed3 == false);

            }
            
            //lets user know program is done and to exit
                Console.WriteLine("Have a Great Day.");
                Console.WriteLine("Press Enter to Quit Program");

            //creates a pause
                Console.Read();
            
        }
    }
}
