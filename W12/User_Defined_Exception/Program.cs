namespace W12_User_Defined_Exception
{
    public class DivideByZeroCustomException : Exception
    {
        public DivideByZeroCustomException(String message)
            : base(message)
        {

        }
    }

    class Program
    {
        public static double Divide()
        {
            Console.WriteLine("Enter the numerator:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator:");
            int denominator = Convert.ToInt32(Console.ReadLine());
            if (denominator == 0)
                throw new DivideByZeroCustomException("The denominator cannot be zero!");

            return (double)(numerator / denominator);
        }
        static void Main(string[] args)
        {
            try
            {
                double result = Divide();
                Console.WriteLine(result);
            }
            catch (DivideByZeroCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}



