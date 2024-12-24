using System;
namespace CokluCatchOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the numerator:");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the denominator:");
                int denominator = Convert.ToInt32(Console.ReadLine());

                double result = (double)(numerator / denominator);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The denominator cannot be zero!");
            }
            catch (Exception ex) when (ex is OverflowException
            || ex is FormatException
            || ex is ArithmeticException)
            {
                Console.WriteLine("You did not enter a number or the number is out of range!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
