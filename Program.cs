using System;

namespace MethodOverloading
{
    internal class Program
    {

        public static int Add(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            decimal answer = num1 + num2:
            Console.WriteLine(answer);
        }
        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = int num1, int num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var x = 32;
            var y = 47;

            var answer = Add(x, y);

            var a = 16.0m;
            var b = 27.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);

        }

    }
}
