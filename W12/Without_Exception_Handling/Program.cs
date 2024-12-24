namespace W12_No_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Explain program as comment briefly
            // Ask user to enter two numbers
            // Read the numbers
            // Divide the first number by the second number
            // Display the result


            Console.Write("Enter the first number: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int denominator = int.Parse(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine("The result is: " + result);


            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();


        }
    }
}
