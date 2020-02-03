using System;

namespace NumeralSystems
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input Number");
            string input = Console.ReadLine();

           // return input;
            //string input = string.Empty;

            MainProgram();

            void MainProgram()
            {
               // input = ReadNumber.AskUser();
                try
                {
                    INumber numberSystems;
                    if (input[0] == '0' && input[1] != 'x' && input[1] != 'X' && input[1] != ',')   //if number is octal
                    {
                        numberSystems = new Octal(input);
                    }
                    else if (input[1] == 'x' || input[1] == 'X')  // if number is hexadecimal
                    {
                       // numberSystems = new Hexadecimal(input);
                    }
                    else // if number is decimal
                    {
                        numberSystems = new Decimal(input);
                    }
                    //numberSystems.ShowResults();
                   // return INumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Error try again");
                }
                LoopOfMainProgram();
            }

            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("Do you want to try another number? \n Type 'yes' or 'exit'");
                    string answer = Console.ReadLine();
                    if (answer == "exit") { Environment.Exit(0); break; }
                    else if (answer == "yes") { Console.Clear(); MainProgram(); break; }
                    else Console.WriteLine("Wrong answer");
                }

            }
        }
    }
}