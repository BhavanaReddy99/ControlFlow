using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            // if-else statement
            int a = 10;
            if (a > 15)
            {
                Console.WriteLine("a is greater than 15.");
            }
            else
            {
                Console.WriteLine("a is not greater than 15.");
            }

            // switch statement
            String Week = "Thursday";
            switch (Week)
            {
                case "Sunday":
                    Console.WriteLine("First Day Of The Week");
                    break;
                case "Monday":
                    Console.WriteLine("Second Day Of The Week");
                    break;
                case "Tuesday":
                    Console.WriteLine("Third  Day Of The Week");
                    break;
                case "Wednesday":
                    Console.WriteLine("Fourth  Day Of The Week");
                    break;
                case "Thursday":
                    Console.WriteLine("Fifth  Day Of The Week");
                    break;
                case "Friday":
                    Console.WriteLine("Sixth  Day Of The Week");
                    break;
                case "Saturday":
                    Console.WriteLine("Seventh  Day Of The Week");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }

            // while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("While loop iteration: " + i);
                i++;
            }

            // for loop
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("For loop iteration: " + j);
            }

            // do-while loop
            int k = 0;
            do
            {
                Console.WriteLine("Do-While loop iteration: " + k);
                k++;
            } while (k < 5);
            string[] numbers = { "One", "Two", "Three", "Four" };
            foreach (string s in numbers)
            {
                Console.WriteLine("Foreach loop to iterate through an array :" + s);
            }
        }
    }
    }
