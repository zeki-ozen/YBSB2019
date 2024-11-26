/********** STRUCTURED PROGRAMMING **********************/
/********** Dr. Zeki Ozen *******************************/
/********** WEEK 8 - Methods by return value types ******/

namespace Method_with_Returning_Value
{
    internal class Program
    {

        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }


        public static void PrintResult(int result)
        {
            Console.WriteLine($"Result: {result}");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = Sum(number1, number2);

            PrintResult(result);

        }
    }
}
