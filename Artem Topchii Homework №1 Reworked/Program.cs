using System;

namespace Project
{
    class Program
    {
        static void ConvertHoursToMinutes()
        {
            Console.WriteLine("Enter number of hours:");
            int hours = Convert.ToInt32(Console.ReadLine());

            int minutes = hours * 60;

            Console.WriteLine(minutes + " min");
        }

        static void SolveTheTask()
        {
            Console.WriteLine("Enter number A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = (5 * a + b * b) / (b - a);

            Console.WriteLine(result);
        }

        static void SwapTheContents()
        {
            Console.WriteLine("Enter value A");
            string a = Console.ReadLine();
            Console.WriteLine("Enter value B");
            string b = Console.ReadLine();

            string temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Swap completed successfully" + Environment.NewLine + "Value A: " + a + Environment.NewLine + "Value B: " + b);
        }

        static void DividingWithRemainder()
        {
            Console.WriteLine("Enter number A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;
            int division_Remainder = a % b;

            Console.WriteLine("Result: " + result + Environment.NewLine + "Division remainder: " + division_Remainder);
        }

        static void SolveTheEquation()
        {
            Console.WriteLine("Enter number A");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number C");
            float c = Convert.ToInt32(Console.ReadLine());

            //Linear equation: A * X + B = C
            float x = (float)Math.Round((c - b) / a, 2);

            Console.WriteLine("X = " + x);
        }

        static void SolveTheEquationOfStraightLine()
        {
            Console.WriteLine("Enter number X1");
            float x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number Y1");
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number X2");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number Y2");
            float y2 = Convert.ToInt32(Console.ReadLine());

            float b = (y1 - y2) / (x1 - x2);
            float a = y2 - b * x2;

            Console.WriteLine("Point A: X1 = " + x1 + " Y1 = " + y1 + Environment.NewLine +
                              "Point B: X2 = " + x2 + " Y2 = " + y2 + Environment.NewLine +
                              "Equation: y = " + b + "x + " + a);
        }

        static void CalculateSumOfDigits()
        {
            Console.WriteLine("Enter two-digit number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n / 10 + " + " + n % 10 + " = " + (n / 10 + n % 10));
        }
        static void Main(string[] args)
        {
            //ConvertHoursToMinutes();
            //SolveTheTask();
            //SwapTheContents();
            //DividingWithRemainder();
            //SolveTheEquation();
            //SolveTheEquationOfStraightLine();
            //CalculateSumOfDigits();
        }
    }
}