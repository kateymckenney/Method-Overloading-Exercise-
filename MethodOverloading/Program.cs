namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool dollars)
        {
            var sum = num1 + num2;

            if (dollars == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (dollars == false && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (dollars == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return $"{sum} dollars";
            }
        }

        static void Main(string[] args)
        {
            var a = 30;
            var b = 35;

            var answer = Add(a, b);

            var x = 34.7m;
            var y = 68.9m;

            var decimalAnswer = Add(x, y);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"integer add {answer}, decimal add {decimalAnswer}.");

        }
    }
}
