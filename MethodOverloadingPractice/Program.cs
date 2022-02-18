using System;

namespace MethodOverloadingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 2);
            Add(2.0m, 2.0m);
            Add(3, 6, true);
            Console.WriteLine(Add (3, 6, true));
        }

        public static int Add(int x, int y)
            {
            return x + y;
            }
        public static decimal Add(decimal x, decimal y)
            {
                return x + y;
        }
        public static string Add(int x, int y, bool isPlural)
        {
            var sum = x + y;
            if(sum == 1)
            {
                isPlural = true;
                return ($"{sum} dollar");
            }
            else
            {
                return ($"{sum} dollars");
            }
         }
    }
}
