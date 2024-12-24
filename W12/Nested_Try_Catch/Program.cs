namespace W12_Nested_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
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
                catch (FieldAccessException e)
                {
                    Console.WriteLine("You cannot access protected or private members. " + e.Message);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred that was not caught in the inner catch block!");
            }
        }
    }
}

