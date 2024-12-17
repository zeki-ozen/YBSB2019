/********** STRUCTURED PROGRAMMING ***/
/********** Dr. Zeki Ozen ************/
/********** WEEK 11 - String Methods */
using System;
using System.Globalization;
using System.Text;


namespace W11_String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Structured Programming II";
            Console.WriteLine($"The string: {str}");

            char letter = str[0]; // S
            Console.WriteLine($"The first letter of the string: {letter}");

            Console.WriteLine("Convert string to char array:");
            char[] letters = str.ToCharArray();
            // S t r u c t u r e d   P r o g r a m m i n g   I I
            foreach (char ch in letters)
                Console.Write(ch + " ");

            // String length
            Console.WriteLine($"String length: {str.Length}"); // 25

            Console.WriteLine("Iterating letters of a string");
            foreach (char c in str)
                Console.Write(c + " ");


            Console.WriteLine();
            // String generation
            string str2 = new string('A', 5); // AAAAA

            Console.WriteLine("Align to the right:");
            Console.WriteLine(String.Format("{0, 30}", str));

            Console.WriteLine("Align to the left:");
            Console.WriteLine(String.Format("{0, -30}", str));


            // string equality using == operator
            string strA = "BA";
            string strB = "ba";
            Console.WriteLine($"{strA} == {strA}: " + (strA == strB)); // False

            // string inequality using != operator
            Console.WriteLine($"{strA} != {strA}: " + (strA != strB)); // True



            Console.WriteLine("\n*** Formatting String ***\n");
            decimal price = 123.456m;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Define US culture
            CultureInfo dollarCulture = new CultureInfo("en-US");
            dollarCulture.NumberFormat.CurrencySymbol = "$"; // Dollar symbol
            Console.WriteLine("Currency (Dollar): " + String.Format(dollarCulture, "{0:c}", price));

            // Define European culture
            CultureInfo euroCulture = new CultureInfo("fr-FR");
            // Unicode for the Euro symbol
            euroCulture.NumberFormat.CurrencySymbol = "\u20AC";
            Console.WriteLine("Currency (Euro): " + String.Format(euroCulture, "{0:c}", price));

            // Using CultureInfo for Pound (£) symbol
            CultureInfo poundCulture = new CultureInfo("en-GB");
            Console.WriteLine("Currency (Pound): " + String.Format(poundCulture, "{0:c}", price)); // £123.46

            // Define Turkish culture
            CultureInfo liraCulture = new CultureInfo("tr-TR");
            liraCulture.NumberFormat.CurrencyPositivePattern = 3; // 3 places the symbol after the number
            // Unicode for the Turkish Lira (₺) symbol
            liraCulture.NumberFormat.CurrencySymbol = "\u20BA"; // Unicode for the Turkish Lira symbol
            Console.WriteLine("Currency (Turkish Lira): " + String.Format(liraCulture, "{0:c}", price));

            Console.WriteLine("\nDecimal: " + String.Format("{0, 0:d5}", 123)); // 00123 
            Console.WriteLine("Decimal Point: " + String.Format("{0, 0:0.00}", 123.456)); // 123.46

            Console.WriteLine("\nScientific: " + String.Format("{0, 0:e}", 123.456)); // 1.234560e+002
            Console.WriteLine("Fixed-point: " + String.Format("{0, 0:f2}", 123.456)); // 123.46
            Console.WriteLine("General: " + String.Format("{0, 0:g}", 123.456)); // 123.456
            Console.WriteLine("Number: " + String.Format("{0, 0:n}", 123456)); // 123,456.00
            Console.WriteLine("\nPercent: " + String.Format("{0, 0:p}", 0.123)); // %12.30
            Console.WriteLine("Percent: " + String.Format("{0, 0:0.00%}", 0.123)); // 12.30%

            Console.WriteLine("\nHexadecimal: " + String.Format("{0, 0:x}", 123)); // 7b

            Console.WriteLine("Zero: " + String.Format("{0, 0:00000}", 123)); // 00123
            Console.WriteLine("Digit: " + String.Format("{0, 0:###}", 123)); // 123
            Console.WriteLine("Thousand Separator: " + String.Format("{0, 0:#,###}", 123456)); // 123,456



            Console.WriteLine("\n*** String Methods ***\n");

            string str3 = "Structured Programming II";
            Console.WriteLine("String: {0}", str3);
            // Clone a string
            string str4 = (string)str3.Clone();
            Console.WriteLine("Cloned string: " + str4);



            // Compare method
            // Return 0 if two strings are equal
            Console.WriteLine("\nCompare two strings {0} and {1}: {2}", str3, str4, String.Compare(str3, str4)); // 0

            string str5 = "Hello";
            string str6 = "Merhaba";
            // Return -1 if the first string is less than the second string
            Console.WriteLine("Compare two strings {0} and {1}: {2}", str5, str6, String.Compare(str5, str6)); // -1
            // Return 1 if the first string is greater than the second string
            Console.WriteLine("Compare two strings {0} and {1}: {2}", str6, str5, String.Compare(str6, str5)); // 1



            // CompareTo Method
            // Return 0 if two strings are equal
            Console.WriteLine("\nCompareTo method {0} and {1}: {2}", str3, str4, str3.CompareTo(str4)); // 0
            // Return -1 if the first string is less than the second string
            Console.WriteLine("CompareTo method {0} and {1}: {2}", str5, str6, str5.CompareTo(str6)); // -1
            // Return 1 if the first string is greater than the second string
            Console.WriteLine("CompareTo method {0} and {1}: {2}", str6, str5, str6.CompareTo(str5)); // 1


            // CompareOrdinal method
            string str7 = "BA";
            string str8 = "DA";
            Console.WriteLine("\nCompareOrdinal method {0} and {1}:", str7, str8);

            int result = String.CompareOrdinal(str7, str8);
            Console.WriteLine("CompareOrdinal result: " + result);

            if (result < 0)
                Console.WriteLine($"{str7} is less than {str8} in ordinal comparison.");
            else if (result > 0)
                Console.WriteLine($"{str7} is greater than {str8} in ordinal comparison.");
            else
                Console.WriteLine($"{str7} and {str8} are equal in ordinal comparison.");


            // Try CompareOrdinal method KA and BA strings


            // Concat method
            string str9 = "Structured";
            string str10 = "Programming";
            string str11 = String.Concat(str9, " ", str10);
            Console.WriteLine("\nConcatenated string: " + str11);

            // Contains method
            Console.WriteLine("\nContains method:");
            string str12 = "Software";
            string str13 = "oft";
            string str14 = "Oft";
            Console.WriteLine("{0} contain the word {1}? {2}", str12, str13, str12.Contains(str13)); // True
            Console.WriteLine("{0} contain the word {1}? {2}", str12, str14, str12.Contains(str14)); // False



            // Copy method
            Console.WriteLine("\nCopy method:");
            string strCopy = String.Copy(str12);
            Console.WriteLine("Copied string: " + strCopy);


            // CopyTo method
            Console.WriteLine("\nCopyTo method:");
            char[] charArray = new char[10];
            str12.CopyTo(0, charArray, 0, 5);
            Console.WriteLine("Copied characters: ");
            foreach (char ch in charArray)
                Console.Write(ch + " ");

            // EndsWith method
            Console.WriteLine("\nEndsWith method:");
            string str15 = "Ware";
            string str16 = "ware";
            Console.WriteLine("{0} ends with {1}? {2}", str12, str15, str12.EndsWith(str15)); // True
            Console.WriteLine("{0} ends with {1}? {2}", str12, str16, str12.EndsWith(str16)); // False


            // StartsWith method
            Console.WriteLine("\nStartsWith method:");
            string str17 = "Soft";
            string str18 = "soft";
            Console.WriteLine("{0} starts with {1}? {2}", str12, str17, str12.StartsWith(str17)); // True
            Console.WriteLine("{0} starts with {1}? {2}", str12, str18, str12.StartsWith(str18)); // False

            // Equals method
            Console.WriteLine("\nEquals method:");
            string str19 = "Software";
            string str20 = "Software";
            string str21 = "software";
            Console.WriteLine("{0} equals to {1}? {2}", str19, str20, str19.Equals(str20)); // True
            Console.WriteLine("{0} equals to {1}? {2}", str19, str21, str19.Equals(str21)); // False


            // GetType method
            Console.WriteLine("\nGetType method:");
            Console.WriteLine("Type of the string: " + str19.GetType());

            // GetHashCode method
            Console.WriteLine("\nGetHashCode method:");
            Console.WriteLine("Hash code of the {0}: {1}: ", str19, str19.GetHashCode());
            Console.WriteLine("Hash code of the {0}: {1}: ", str21, str21.GetHashCode());

            // IndexOf method
            Console.WriteLine("\nIndexOf method:");
            string str22 = "Programming";
            string str23 = "g";
            string str24 = "G";
            Console.WriteLine("Index of the word {0} in the string {1}: {2}", str23, str22, str22.IndexOf(str23)); // 3
            Console.WriteLine("Index of the word {0} in the string {1}: {2}", str24, str22, str22.IndexOf(str24)); // -1


            // LastIndexOf method
            Console.WriteLine("\nLastIndexOf method:");
            string str25 = "Programming";
            string str26 = "g";
            string str27 = "G";
            Console.WriteLine("Last index of the word {0} in the string {1}: {2}", str26, str25, str25.LastIndexOf(str26)); // 10
            Console.WriteLine("Last index of the word {0} in the string {1}: {2}", str27, str25, str25.LastIndexOf(str27)); // -1


            // Insert method
            Console.WriteLine("\nInsert method:");
            
            string str28 = "Structured ";
            string str29 = "Programming ";
            string str30 = "II";
            Console.WriteLine("Insert {0} into {1}: {2}", str28, str29, str29.Insert(0, str28)); // Structured Programming
            Console.WriteLine("Insert {0} into {1} and {2}: {3}", str28, str29, str30, str30.Insert(0, str29.Insert(0, str28))); // Structured Programming II


            // IsNullOrEmpty method
            Console.WriteLine("\nIsNullOrEmpty method:");
            string str31 = "";
            string str32 = null;
            string str33 = "Structured Programming";
            Console.WriteLine("IsNullOrEmpty for #{0}#: {1}", str31, String.IsNullOrEmpty(str31)); // True
            Console.WriteLine("IsNullOrEmpty for #{0}#: {1}", str32, String.IsNullOrEmpty(str32)); // True
            Console.WriteLine("IsNullOrEmpty for #{0}#: {1}", str33, String.IsNullOrEmpty(str33)); // False


            // IsNullOrWhiteSpace method
            Console.WriteLine("\nIsNullOrWhiteSpace method:");
            Console.WriteLine("IsNullOrWhiteSpace for #{0}#: {1}", str31, String.IsNullOrWhiteSpace(str31)); // True
            Console.WriteLine("IsNullOrWhiteSpace for #{0}#: {1}", str32, String.IsNullOrWhiteSpace(str32)); // True
            Console.WriteLine("IsNullOrWhiteSpace for #{0}#: {1}", str33, String.IsNullOrWhiteSpace(str33)); // False



            // Join method
            Console.WriteLine("\nJoin method:");
            string[] str34 = { "Structured", "Programming", "II" };
            string str35 = String.Join(" ", str34);
            Console.WriteLine("Join the string array: {0}", str35);


            // PadLeft method
            Console.WriteLine("\nPadLeft method:");
            string str36 = "Structured";
            Console.WriteLine("PadLeft the string {0}: {1}", str36, str36.PadLeft(20)); // "          Structured"

            // PadRight method
            Console.WriteLine("\nPadRight method:");
            string str37 = "Structured";
            Console.WriteLine("PadRight the string {0}: {1}", str37, str37.PadRight(20)); // "Structured          "


            // Remove method
            Console.WriteLine("\nRemove method:");
            string str38 = "Structured Programming II";
            Console.WriteLine("Remove the word {0} from the string {1}: {2}", "II", str38, str38.Remove(str38.Length - 2)); // Structured Programming

            // Remove first 3 letters
            Console.WriteLine("Remove the first 3 letters from the string {0}: {1}", str38, str38.Remove(0, 3)); // uctured Programming II

            // Remove last 3 letters
            Console.WriteLine("Remove the last 3 letters from the string {0}: {1}", str38, str38.Remove(str38.Length - 3)); // Structured Programming

            // Remove the lettres between 3 and 6
            Console.WriteLine("Remove the letters between 3 and 6 from the string {0}: {1}", str38, str38.Remove(3, 6)); // Str Programming II

            // Replace method
            Console.WriteLine("\nReplace method:");
            string str39 = "Software Development";
            string oldStr = "Development";
            string newStr = "Engineering";
            Console.WriteLine("Replace the word \"{0}\" with \"{1}\" in the string {2}: {3}",  oldStr, newStr, str39, str39.Replace(oldStr, newStr)); // Structured Programming III


            // Split method
            Console.WriteLine("\nSplit method:");
            string str40 = "Structured Programming II";
            string[] words = str40.Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);

            // Split the "212-440-00-00" with dash

            // Substring method
            Console.WriteLine("\nSubstring method:");
            string str41 = "Structured Programming II";
            // substring from the 0th index to the 10th index
            Console.WriteLine("Substring from the 0th index to the 10th index: {0}", str41.Substring(0, 10)); // Structured

            // Substring from the 11th index to the end
            Console.WriteLine("Substring from the 11th index to the end: {0}", str41.Substring(11)); // Programming II

            // ToCharArray method
            Console.WriteLine("\nToCharArray method:");
            string str42 = "Structured Programming II";
            char[] chars = str42.ToCharArray();
            foreach (char ch in chars)
                Console.Write(ch + " ");


            // ToLower method
            Console.WriteLine("\n\nToLower method:");
            string str43 = "Güneş";
            Console.WriteLine("Lower case of the string {0}: {1}", str43, str43.ToLower());

            // ToUpper method
            Console.WriteLine("\nToUpper method:");
            Console.WriteLine("Upper case of the string {0}: {1}", str43, str43.ToUpper());

            // ToLowerInvariant method
            Console.WriteLine("\nToLowerInvariant method:");
            Console.WriteLine("Lower case of the string using ToLowerInvariant method {0}: {1}", str43, str43.ToLowerInvariant()); // güneş

            // ToUpperInvariant method
            Console.WriteLine("\nToUpperInvariant method:");
            Console.WriteLine("Upper case of the string using ToUpperInvariant method {0}: {1}", str43, str43.ToUpperInvariant()); // GÜNEŞ

            // Trim method
            Console.WriteLine("\nTrim method:");
            string str44 = "   Structured Programming II   ";
            Console.WriteLine("Trim the string {0}: #{1}#", str44, str44.Trim());


            // TrimEnd method
            Console.WriteLine("\nTrimEnd method:");
            Console.WriteLine("TrimEnd the string {0}: #{1}#", str44, str44.TrimEnd());

            // TrimStart method
            Console.WriteLine("\nTrimStart method:");
            Console.WriteLine("TrimStart the string {0}: #{1}#", str44, str44.TrimStart());




        }
    }
}
