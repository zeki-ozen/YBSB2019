/********** STRUCTURED PROGRAMMING **********/
/********** Dr. Zeki Ozen *******************/
/********** WEEK 8 - Intoduction to Method **/

using System;

internal class Program
{

    // Define a method that calculates the price of apples and pears with VAT
    private static decimal CalculatePriceWithVat(decimal price, double vatRate)
    {
        return Math.Round(price * (1 + (decimal)(vatRate / 100)), 2);
    }

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
        decimal applePriceWithVat = CalculatePriceWithVat(applePrice, vatRate);
        decimal pearPriceWithVat = CalculatePriceWithVat(pearPrice, vatRate);

        // Print the prices of apples and pears with VAT
        Console.WriteLine("The price of apples with VAT is: " + applePriceWithVat);
        Console.WriteLine("The price of pears with VAT is: " + pearPriceWithVat);

    }
}