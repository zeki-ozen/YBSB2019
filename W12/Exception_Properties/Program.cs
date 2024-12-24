using System;

namespace ExceptionProperties
{
    class Program
    {
        public static double Divide()
        {
            Console.WriteLine("Enter the numerator:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator:");
            int denominator = Convert.ToInt32(Console.ReadLine());
            return (double)(numerator / denominator);
        }
        static void Main(string[] args)
        {
            try
            {
                double result = Divide();
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex_divide)
            {
                Console.WriteLine("The denominator cannot be zero!");
            }
            catch (Exception ex) when (ex is OverflowException
            || ex is FormatException
            || ex is ArithmeticException)
            {
                Console.WriteLine("You did not enter a number or the number is out of range!");
                Console.WriteLine("---Exception Details---");
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine("Exception Source: {0}", ex.Source);
                Console.WriteLine("Exception Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Exception Target Site: {0}", ex.TargetSite);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
