using System;
namespace W12_Multiple_Exceptions
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
            catch (FormatException ex)
            {
                Console.WriteLine("You did not enter a number!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
