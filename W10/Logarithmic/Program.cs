/********** STRUCTURED PROGRAMMING ************************/
/********** Dr. Zeki Ozen *********************************/
/********** WEEK 10 - Logarithmic Methods of Math Class ***/
namespace W10_Logarithmic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Math.Log() Method
            // Return the natural logarithm of a specified number
            // log = ln
            Console.WriteLine(Math.Log(2.718281828459045)); // 1

            // Math.Log(number, base) Method
            // Return the logarithm of a specified number in a specified base
            // log = log_base(number)
            Console.WriteLine(Math.Log(100, 10)); // 2
            Console.WriteLine(Math.Log(100, 2)); // 6.643856189774724

            // Math.Log10() Method
            // Return the base 10 logarithm of a specified number
            // log10 = log_10
            Console.WriteLine(Math.Log10(100)); // 2


            // Math.Log2() Method
            // Return the base 2 logarithm of a specified number
            // log2 = log_2
            Console.WriteLine(Math.Log2(100)); // 6.643856189774724


            // Math.ILogB() Method
            // Return the integral binary logarithm of a specified number
            // ilogb = log_2
            Console.WriteLine(Math.ILogB(100)); // 6


        }
    }
}
