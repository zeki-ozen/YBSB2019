namespace W12_Zero_Divide_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int denominator = int.Parse(Console.ReadLine());

            try
            {
                int result = numerator / denominator;
                Console.WriteLine("The result is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
                //Console.WriteLine("Cannot divide by zero" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
            }
            
        }
    }
}
