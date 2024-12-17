/********** STRUCTURED PROGRAMMING *****/
/********** Dr. Zeki Ozen **************/
/********** WEEK 11 - DateTime Methods */
using System.Globalization;

namespace W11_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create DateTime Object
            DateTime dateTime = new DateTime();
            Console.WriteLine("Default DateTime value: {0}", dateTime); // 1/1/0001 12:00:00 AM

            // Set Current DateTime
            dateTime = DateTime.Now;
            Console.WriteLine("Current DateTime value: {0}", dateTime);

            // Create DateTime Object with Year, Month, Day
            dateTime = new DateTime(2024, 12, 18);
            Console.WriteLine("DateTime value with Year, Month, Day: {0}", dateTime);

            // Create DateTime Object with Year, Month, Day, Hour, Minute, Second
            dateTime = new DateTime(2024, 12, 18, 15, 45, 00);
            Console.WriteLine("DateTime value with Year, Month, Day, Hour, Minute, Second: {0}", dateTime);


            // Create Today's DateTime
            DateTime date = DateTime.Today;
            Console.WriteLine("Today: {0}", date);

            // Create DateOnly Object
            DateOnly dateOnly = new DateOnly(2024, 12, 18);
            Console.WriteLine("DateOnly value: {0}", dateOnly);


            // Create TimeOnly Object
            TimeOnly timeOnly = new TimeOnly(15, 45, 00);
            Console.WriteLine("TimeOnly value: {0}", timeOnly);

            // Storing  Days, Hours, Minutes, Seconds in TimeSpan
            TimeSpan timeSpan = new TimeSpan(5, 10, 15, 20);
            Console.WriteLine("TimeSpan value: {0}", timeSpan);

            // Setting Turkish DateTime Format
            CultureInfo trCulture = new CultureInfo("tr-TR");
            Console.WriteLine("Turkish DateTime Format: {0}", dateTime.ToString("D", trCulture));


            Console.WriteLine("\n********************");
            Console.WriteLine("DateTime Properties:");
            Console.WriteLine("********************");
            dateTime = DateTime.Today;

            Console.WriteLine("Year: {0}", dateTime.Year);
            Console.WriteLine("Month: {0}", dateTime.Month);
            Console.WriteLine("Day: {0}", dateTime.Day);
            Console.WriteLine("Hour: {0}", dateTime.Hour);
            Console.WriteLine("Minute: {0}", dateTime.Minute);
            Console.WriteLine("Second: {0}", dateTime.Second);
            Console.WriteLine("Millisecond: {0}", dateTime.Millisecond);
            Console.WriteLine("DayOfWeek: {0}", dateTime.DayOfWeek);
            Console.WriteLine("DayOfYear: {0}", dateTime.DayOfYear);
            Console.WriteLine("Ticks: {0}", dateTime.Ticks);
            Console.WriteLine("Kind: {0}", dateTime.Kind);
            Console.WriteLine("Date: {0}", dateTime.Date);
            Console.WriteLine("TimeOfDay: {0}", dateTime.TimeOfDay);
            Console.WriteLine("IsDaylightSavingTime: {0}", dateTime.IsDaylightSavingTime());
            Console.WriteLine("IsLeapYear: {0}", DateTime.IsLeapYear(dateTime.Year));


            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime custom format specifiers:");
            Console.WriteLine("*********************************");

            // Turkish culture
            dateTime = DateTime.Today;
            Console.WriteLine("d: {0}", dateTime.ToString("d")); // 18.12.2024
            Console.WriteLine("D: {0}", dateTime.ToString("D")); // 18 Aralik 2024 Çarsamba
            Console.WriteLine("f: {0}", dateTime.ToString("f")); // 18 Aralik 2024 Çarsamba 00:00
            Console.WriteLine("F: {0}", dateTime.ToString("F")); // 18 Aralik 2024 Çarsamba 00:00:00
            Console.WriteLine("g: {0}", dateTime.ToString("g")); // 18.12.2024 00:00
            Console.WriteLine("G: {0}", dateTime.ToString("G")); // 18.12.2024 00:00:00
            Console.WriteLine("m: {0}", dateTime.ToString("m")); // 18 Aralik
            Console.WriteLine("M: {0}", dateTime.ToString("M")); // 18 Aralik
            Console.WriteLine("o: {0}", dateTime.ToString("o")); // 2024-12-18T00:00:00.0000000+03:00
            Console.WriteLine("R: {0}", dateTime.ToString("R")); // Wed, 18 Dec 2024 00:00:00 GMT
            Console.WriteLine("s: {0}", dateTime.ToString("s")); // 2024-12-18T00:00:00
            Console.WriteLine("t: {0}", dateTime.ToString("t")); // 00:00
            Console.WriteLine("T: {0}", dateTime.ToString("T")); // 00:00:00
            Console.WriteLine("u: {0}", dateTime.ToString("u")); // 2024-12-18 00:00:00Z
            Console.WriteLine("U: {0}", dateTime.ToString("U")); // 17 Aralik 2024 Sali 21:00:00
            Console.WriteLine("y: {0}", dateTime.ToString("y")); // Aralik 2024
            Console.WriteLine("Y: {0}", dateTime.ToString("Y")); // Aralik 2024



            Console.WriteLine("dd: {0}", dateTime.ToString("dd")); // 18
            Console.WriteLine("ddd: {0}", dateTime.ToString("ddd")); // Çar
            Console.WriteLine("dddd: {0}", dateTime.ToString("dddd")); // Çarsamba
            Console.WriteLine("gg: {0}", dateTime.ToString("gg")); // MS
            Console.WriteLine("hh: {0}", dateTime.ToString("hh")); // 12

            Console.WriteLine("MMM: {0}", dateTime.ToString("MMM")); // Ara
            Console.WriteLine("MMMM: {0}", dateTime.ToString("MMMM")); // Aralik                                                         // 

            Console.WriteLine("tt: {0}", dateTime.ToString("tt")); //  ÖÖ or ÖS
            Console.WriteLine("yy: {0}", dateTime.ToString("yy")); // 24
            Console.WriteLine("yy: {0}", dateTime.ToString("yyyy")); // 2024
            Console.WriteLine("zz: {0}", dateTime.ToString("zz")); // +03



            DateTime zaman = new DateTime(2024, 12, 18, 16, 05, 35);
            Console.WriteLine(zaman.ToString("gg dd MMMM yyyy dddd zzz"));
            // MS 18 Aralik 2024 Çarsamba +03:00
            Console.WriteLine("{0:HH:mm tt}", zaman); // 16:05 ÖS
            Console.WriteLine(String.Format("{0:gg dd MMMM yyyy dddd zzz}", zaman));
            // MS 18 Aralik 2024 Çarsamba +03:00

            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime Add Methods:");
            Console.WriteLine("*********************************");
            DateTime today = new DateTime();
            today = DateTime.Today;

            Console.WriteLine("Today: {0}", today);
            Console.WriteLine("AddDays(5): {0}", today.AddDays(5));
            Console.WriteLine("AddMonths(2): {0}", today.AddMonths(2));
            Console.WriteLine("AddYears(3): {0}", today.AddYears(3));
            Console.WriteLine("AddHours(4): {0}", today.AddHours(4));
            Console.WriteLine("AddMinutes(30): {0}", today.AddMinutes(30));
            Console.WriteLine("AddSeconds(45): {0}", today.AddSeconds(45));

            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime Subtract Methods:");
            Console.WriteLine("*********************************");
            DateTime birthDate = new DateTime(1983, 01, 09);

            TimeSpan age = today.Subtract(birthDate);
            Console.WriteLine("Age: {0}", age.Days / 365);

            // Calculate your age modifiying the birthDate



            // Subtracting 2 hour, 18 minutes, 15 seconds from today
            DateTime dateDiff = today.Subtract(new TimeSpan(2, 18, 15));
            Console.WriteLine("Subtracting 2 hour, 18 minutes, 15 seconds from now: {0}", dateDiff);

            // Subtracting 2 days from today
            dateDiff = today.Subtract(new TimeSpan(2, 0, 0, 0));
            Console.WriteLine("Subtracting 2 days from now: {0}", dateDiff);

            // Subtracting 2 hours from today
            dateDiff = today.AddHours(-2);
            Console.WriteLine("Subtracting 2 hours from now: {0}", dateDiff);


            // Subtracting 2 months from today
            dateDiff = today.AddMonths(-2);
            Console.WriteLine("Subtracting 2 months from now: {0}", dateDiff);

            // Subtracting 2 years from today
            dateDiff = today.AddYears(-2);
            Console.WriteLine("Subtracting 2 years from now: {0}", dateDiff);


            // subtract two DateTime objects
            Console.WriteLine("\nSubtracting two DateTime objects:");
            DateTime date1 = new DateTime(2024, 12, 18, 16, 15, 33);
            DateTime date2 = new DateTime(2024, 03, 22);
            TimeSpan diff = date1.Subtract(date2);
            Console.WriteLine("Difference between two dates: {0}", diff);

            // format diff as months and days
            Console.WriteLine("Difference between two dates: {0} months and {1} days", diff.Days / 30, diff.Days % 30);



            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime Compare Methods:");
            Console.WriteLine("*********************************");

            // Compare two DateTime objects
            DateTime date3 = new DateTime(2024, 12, 18, 16, 15, 33);
            DateTime date4 = new DateTime(2024, 03, 22);

            Console.WriteLine("date3: {0}", date3);
            Console.WriteLine("date4: {0}", date4);
            double compare = DateTime.Compare(date3, date4);
            if (compare > 0)
            {
                Console.WriteLine("{0} is later than {1}", date3, date4);
            }
            else if (compare < 0)
            {
                Console.WriteLine("{0} is earlier than {1}", date3, date4);
            }
            else
            {
                Console.WriteLine("{0} is the same as {1}", date3, date4);
            }


            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime Equals Methods:");
            Console.WriteLine("*********************************");

            bool isEqualDate = date3.Equals(date4);
            Console.WriteLine($"{date3} is Equals {date4}: {isEqualDate}");



            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime Parse Methods:");
            Console.WriteLine("*********************************");

            string tarih = "18.12.2024 16:15:33";
            Console.WriteLine("String Date: {0}", tarih);
            try
            {
                DateTime parsedDate = DateTime.Parse(tarih);
                Console.WriteLine("Parsed Date: {0}", parsedDate);

                // ParseExact Method
                DateTime parsedDate2 = DateTime.ParseExact(tarih, "dd/MMMM/yyyy ", new CultureInfo("tr-TR"));
                Console.WriteLine("ParseExact Date: {0}", parsedDate2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }



            Console.WriteLine("\n********************************");
            Console.WriteLine("DateTime TryParse Methods:");
            Console.WriteLine("*********************************");

            // Notice that the year is missing in the date string
            string tarih2 = "18.12. 16:15:33";
            Console.WriteLine("String Date: {0}", tarih2);
            DateTime parsedDate3;
            if (DateTime.TryParse(tarih2, out parsedDate3))
            {
                Console.WriteLine("TryParse Date: {0}", parsedDate3);
            }
            else
            {
                Console.WriteLine("Invalid Date Format");
            }
        }
    }
}
