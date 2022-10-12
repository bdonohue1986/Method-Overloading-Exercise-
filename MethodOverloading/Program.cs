namespace MethodOverloading
{
    internal class Program
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Add(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static string Add(double num1, double num2, bool rightOn)
        {
            var sum = num1 + num2;
             
            if (rightOn == true && sum >= 0)
            {
                return $" ${sum} Dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[]args)
        {
            var x = 78.9;
            var y = 10.76;

            var answer = Add(x, y, true);

            Console.WriteLine($"when adding {x} and {y} you will come out with {answer}");
        }
    }
}