using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Mid_Term
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            int quantityOfStudent = 1;
            int[] Scorem, Scorer, Scoreg;
            string[] phat;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityOfStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            phat = new string[quantityOfStudent];
            Scorem = new int[quantityOfStudent];
            Scorer = new int[quantityOfStudent];
            Scoreg = new int[quantityOfStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iterator = 0; iterator < quantityOfStudent; iterator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({iterator + 1} of {quantityOfStudent}) name : ");
                phat[iterator] = Console.ReadLine();

                Console.Write($"Please key {phat[iterator]}'s middle score : ");
                Scorem[iterator] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {phat[iterator]}'s final score : ");
                Scorer[iterator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                Scoreg[iterator] = Scorem[iterator] + Scorer[iterator];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int @int = 0;

            do
            {
                float Scorephat = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (Scoreg[@int] <= 49) Scorephat = 0f;
                else if (Scoreg[@int] <= 54) Scorephat = 1f;
                else if (Scoreg[@int] <= 59) Scorephat = 1.5f;
                else if (Scoreg[@int] <= 64) Scorephat = 2f;
                else if (Scoreg[@int] <= 69) Scorephat = 2.5f;
                else if (Scoreg[@int] <= 74) Scorephat = 3f;
                else if (Scoreg[@int] <= 79) Scorephat = 3.5f;
                else if (Scoreg[@int] >= 80) Scorephat = 4f;

                #endregion

                #region Writing an if..else..if code with curly brackets.
                /*
                if (sumScore[_iterator] <= 49)
                {
                    gradesScore = 0f;
                }
                else if (sumScore[_iterator] <= 54)
                {
                    gradesScore = 1f;
                }
                else if (sumScore[_iterator] <= 59)
                {
                    gradesScore = 1.5f;
                }
                else if (sumScore[_iterator] <= 64)
                {
                    gradesScore = 2f;
                }
                else if (sumScore[_iterator] <= 69)
                {
                    gradesScore = 2.5f;
                }
                else if (sumScore[_iterator] <= 74)
                {
                    gradesScore = 3f;
                }
                else if (sumScore[_iterator] <= 79)
                {
                    gradesScore = 3.5f;
                }
                else if (sumScore[_iterator] >= 80)
                {
                    gradesScore = 4f;
                }
                */
                #endregion

                Console.WriteLine($"{@int + 1}. {phat[@int]} have a" +
                                $" total {Scoreg[@int]} score or {Scorephat} grades.");
                @int++;
            } while (@int < quantityOfStudent);

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}
