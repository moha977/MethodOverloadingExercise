using System;

namespace MethodOverloadingExercise
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;
            if (isTrue && sum > 1 || sum < 1)
            {
                return $"{sum} dollars";
            }
            else if(isTrue && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        

        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(7, 8));
            Console.WriteLine();
            Console.WriteLine(Add(8.2m, 15.3m));
            Console.WriteLine();
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine();
            Console.WriteLine(Add(10, 13, true));
            Console.WriteLine();
            Console.WriteLine(Add(5, 12, false));
            Console.WriteLine();
            Console.WriteLine(Add(-6, 1, true));
            Console.WriteLine();
        }
    }
}
