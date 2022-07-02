using System;

namespace Project
{
    class Program
    {
        static int ConvertHoursToMinutes(int numberOfHours)
        {
            return numberOfHours * 60;
        }

        static int SolveTheTask(int a, int b)
        {
            return (5 * a + b * b) / (b - a);
        }

        static string SwapTheContents(string a, string b)
        {
            string temp = a;
            a = b;
            b = temp;

            return "Value A: " + a + Environment.NewLine + "Value B: " +  b;
        }

        static (int, int) DividingWithRemainder(int a, int b)
        {
            return (a / b, a % b);
        }

        static float SolveTheEquation(float a, float b, float c)
        {
            //Linear equation: A * X + B = C
            return (float)Math.Round((c - b) / a, 2);
        }

        static (float, float) SolveTheEquationOfStraightLine(float x1, float x2, float y1, float y2)
        {
            float b = (y1 - y2) / (x1 - x2);
            float a = y2 - b * x2;

            return (a, b);
        }

        static (int, int) CalculateSumOfDigits(int n)
        {
            return (n / 10, n % 10);
        }

        public static void Main()
        {
         //CONVERT HOURS TO MINUTES

            //int numberOfHours = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(ConvertHoursToMinutes(numberOfHours) + " min");

         //SOLVE THE TASK

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(SolveTheTask(a, b));

         //SWAP CONTENTS

            //Console.WriteLine("Enter value A");
            //string a = Console.ReadLine();
            //Console.WriteLine("Enter value B");
            //string b = Console.ReadLine();

            //Console.WriteLine("Swap completed successfully" + Environment.NewLine + SwapTheContents(a, b));

         //DIVIDING WITH REMAINDER

            //Console.WriteLine("Enter number A");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number B");
            //int b = Convert.ToInt32(Console.ReadLine());

            //(int result, int remainder) = DividingWithRemainder(a, b);

            //Console.WriteLine("Result = " + result + Environment.NewLine +
            //                  "Remainder = " + remainder);

         //SOLVE THE EQUATION

            //Console.WriteLine("Enter number A");
            //float a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number B");
            //float b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number C");
            //float c = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("X = " + SolveTheEquation(a, b, c));

         //SOLVE THE EQUATION OF STRAIGHT LINE

            //Console.WriteLine("Enter number X1");
            //float x1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number Y1");
            //float y1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number X2");
            //float x2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number Y2");
            //float y2 = Convert.ToInt32(Console.ReadLine());

            //(float a, float b) = SolveTheEquationOfStraightLine(x1, x2, y1, y2);

            //Console.WriteLine("Equation: y = " + b + "x + " + a);

         //CALCULATE SUM OF DIGITS

            //Console.WriteLine("Enter number two digits number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //(int firstDigit, int secondDigit) = CalculateSumOfDigits(n);

            //Console.WriteLine(firstDigit + " + " + secondDigit + " = " + (firstDigit + secondDigit));
        }

    }
}