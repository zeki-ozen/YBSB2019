/********** STRUCTURED PROGRAMMING **********/
/********** Dr. Zeki Ozen *******************/
/********** WEEK 8 - Intoduction to Method **/

using System;

internal class Program
{
    private static void Main(string[] args)
    {

        // Calculate apples and pear price with VAT
        // Ask prices of apples and pears
        Console.WriteLine("Enter the price of apples: ");
        decimal applePrice = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price of pears: ");
        decimal pearPrice = decimal.Parse(Console.ReadLine());

        // Ask VAT rate
        Console.WriteLine("Enter the VAT rate: ");
        double vatRate = double.Parse(Console.ReadLine());

        // Calculate the price of apples and pears with VAT
        decimal applePriceWithVat = Math.Round(applePrice * (1 + (decimal)(vatRate / 100)), 2);
        decimal pearPriceWithVat = Math.Round(pearPrice * (1 + (decimal)(vatRate / 100)), 2);

        // Print the prices of apples and pears with VAT
        Console.WriteLine("The price of apples with VAT is: " + applePriceWithVat);
        Console.WriteLine("The price of pears with VAT is: " + pearPriceWithVat);
    }
}

