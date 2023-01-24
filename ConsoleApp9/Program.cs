using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // задание 1.1

            /*for (int i = 1; i < 15; i++)
                {
                   Write("#");
                }
            for (int i = 1; i < 10; i++)
            {
                WriteLine("#");
            }*/


            // задание 1.2

            /*for (int i = 0; i < 15; i++)
            {
                Write("#");
            }
            for (int i = 0; i < 10; i++)
            {
                WriteLine("              # ");
            }*/

            // задание 1.3

            /* for (int i = 1; i < 9; i++)
                 {
                    WriteLine("#");
                 }
                 for (int i = 1; i < 15; i++)
                 {
                    Write("#");
                 }*/

            // задание 1.4

            /*for (int i = 1; i < 9; i++)
            {
                WriteLine("             #");
            }
            for (int i = 1; i < 15; i++)
            { 
               Write("#");
            }*/

            //задание 2
            /* for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 20; j++)
                 {
                     if (i == 0 || i == 9 || j == 0 || j == 19)
                     {
                         Write("#");
                     }
                     else
                     {
                         Write(" ");
                     }
                 }
                 WriteLine();
             }*/

            // задание 3
            /*for (int i = 1; i < 6; i++)
            {
                for (int b = 0; b < 6 - i; b++)
                
                    Write($"{b} ");
                    WriteLine();
                
            }*/

            // задание 4
            for (int i = 1; i < 5; i++)
            {
                for (int y = 1; y < 6; y++)
                {
                    Write("2   ");
                }
                WriteLine();

            }
            ReadKey();

        }
    }

}