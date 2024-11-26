/********** STRUCTURED PROGRAMMING ****************/
/********** Dr. Zeki Ozen *************************/
/********** WEEK 8 - Static vs NonStatic Methods **/

namespace staticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the static method
            PrintOut.PrintInfo();

            // Create an object of the PrintOut class
            PrintOut prntout = new PrintOut();

            // Call the instance method
            prntout.Display();
        }
    }
}
