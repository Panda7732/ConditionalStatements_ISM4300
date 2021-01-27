/*
 Name: Amanda Hernandez
Date:1/26/2021
Description: ISM 4300 Deliverable 2 - Conditional Statements
*/
using System;

namespace ConditionalStatements_ISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to insert grade
            Console.WriteLine("What is your expected grade for ISM 4300?");

            try
            {
                //read input and assign variable grade as integer
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                //if else if statement to assign letter grades to numeric value

                if (grade >= 90)
                {
                    Console.WriteLine("A");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("B");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                else if (grade >=70)
                {
                    Console.WriteLine("C");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }

                else if (grade >= 60)
                {
                    Console.WriteLine("D");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("F");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);
                }
                

            }
            //try ends
          
            catch
            {
                //tell user to type integer when they put noninteger characters
                Console.WriteLine("Please enter an integer value");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
            //catch ends
            }
        }
    }

