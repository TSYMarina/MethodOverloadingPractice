using System;

namespace MethodOverloadingPractice
{
    class Program
    {
        public static int Add(int x, int y)
            {
            return x + y;
            }
        public static decimal Add(decimal a, decimal b)
            {
                return a + b;
        }
        public static string Add(int x, int y, bool isPlural)
        {
            var sum = x + y;
            if (isPlural == true && sum > 1)
            {
                return ($"{sum} dollars");
            }
            else if (isPlural == true && sum == 1)
            {
                return ($"{sum} dollar");
            }
            else if(isPlural == true && sum < 1)
            {
                return ($"{sum} dollars");
            }
            else
            {
                return sum.ToString();
            }
         }

        static void Main(string[] args)
        {
            var x = 12;
            var y = 11;
            var intAnswer = Add(x, y);

            var a = 56.23m;
            var b = 36.25m;
            var decAnswer = Add(a, b);

            var moneySum = Add(1, 0, true);

            Console.WriteLine($"Int sum: {intAnswer}; \nDecimal sum: {decAnswer};");
            Console.WriteLine($"Counting Money: {moneySum}.");

        }
    }
}
