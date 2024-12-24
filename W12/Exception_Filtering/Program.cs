namespace W12_Exception_Filtering
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] departments = {"Management Information Systems",
                "Computer Programming",
                "History",
                "Sociology",
                "Physics" };

            Console.WriteLine("Enter an index value between 0 and {0}:", departments.Length - 1);
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(departments[index]);
            }
            catch (IndexOutOfRangeException) when (index < 0)
            {
                Console.WriteLine("Index value cannot be negative!");
            }
            catch (IndexOutOfRangeException) when (index > departments.Length - 1)
            {
                Console.WriteLine("Index value can be at most {0}!", departments.Length - 1);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

