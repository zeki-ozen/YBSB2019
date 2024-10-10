// Structured Programming II
// WEEK 2
// ARRAYS
// Assoc. Prof. Zeki Özen



// Create an array of 5 integers
int[] numbers = new int[5];

// Create an array of 5 characters
char[] characters = new char[5];

// Create an array of 5 strings
string[] strings = new string[5];


// Create an array of 5 integers and initialize it
int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

// Create an array of 5 characters and initialize it
char[] characters2 = new char[] { 'a', 'b', 'c', 'd', 'e' };


string[] names = new string[3];
names[0] = "Zeki";
names[1] = "Ahmet";
names[2] = "Mehmet";


// in C# indexes start with 0

// Cretaing an array second way using curly braces
string[] names2 = { "Zeki", "Ahmet", "Mehmet" };
//Console.WriteLine(names2);

char[] karakter = new char[3];
karakter[2] = 'a';
Console.WriteLine(karakter[2]); // a
Console.WriteLine(karakter[0]); // a

int[] sayilar2 = new int[3];
sayilar2[0] = 1;
Console.WriteLine(sayilar2[2]); // 0

//sayilar2[-1] = -1;
// Console.WriteLine(sayilar2[-1]); // ERROR

// sayilar2[3] = 3; // ERROR



int[] numbers_a = new int[] { 5, 10, 15 };


for (int i = 0; i < numbers_a.Length; i++)
{
    Console.WriteLine($"{i + 1}. value = {numbers_a[i]}");
    //Console.WriteLine("{0}. value = {1}", i + 1, numbers_a[i]);
}



foreach (int number in numbers_a)
{
    Console.WriteLine(number);
}



// Create multidimensional array
int[,] matrix = new int[3, 3];
int[,] twodimensional = new int[2, 3];
int[,,] threedimensional = new int[5, 3, 10];


int[,] matris2 = new int[2, 5] {
    {0, 2, 4, 6, 8},
    {1, 3, 5, 7, 9}
};


int[,] sayilar = new int[2, 2];
sayilar[0, 0] = 1;
sayilar[0, 1] = 3;
sayilar[1, 0] = 0;
sayilar[1, 1] = 2;

Console.WriteLine(sayilar[0, 0]); // 1


// other way to create multidimensional array
int[,] matris3 = new int[2, 5];
matris2[0, 0] = 0;
matris2[0, 1] = 2;
matris2[0, 2] = 4;
matris2[0, 3] = 6;
matris2[0, 4] = 8;
matris2[1, 0] = 1;
matris2[1, 1] = 3;
matris2[1, 2] = 5;
matris2[1, 3] = 7;
matris2[1, 4] = 9;


// access the elements of the array
numbers[0] = 10;
numbers[1] = 20;

// assigning value of the first element
numbers[0] = 100;

// assigning value of the last element
numbers[numbers.Length - 1] = 500;

// print the first element
Console.WriteLine(numbers[0]);

// print the last element
Console.WriteLine(numbers[numbers.Length - 1]);





// iterate over the array using for loop
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}


// iterate over the array using foreach loop
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


// iterate over the array using while loop
int j = 0;
while (j < numbers.Length)
{
    Console.WriteLine(numbers[j]);
    j++;
}


// iterate over the array using do-while loop
int k = 0;
do
{
    Console.WriteLine(numbers[k]);
    k++;
} while (k < numbers.Length);




// Exercise
string[] fruits = { "Apple", "Banana", "Cherry" };
// iterate over the array using for loop



// creating and iterating multidimensional array
int[,] numbers4 =
{
    {1, 2, 3},
    {4, 5, 6}
};

// iterate multi-dimensional array using for loop
for (int i = 0; i < numbers4.GetLength(0); i++)
{
    for (int j_ = 0; j_ < numbers4.GetLength(1); j_++)
    {
        Console.WriteLine(numbers4[i, j_]);
    }
}





// array errors and issues

int[] numbers5 = new int[] { 1, 2, 3, 4, 5 };

// accessing out of bounds element
// Console.WriteLine(numbers5[5]);
//numbers5[6] = 10;

// assigning wrong data type value
// numbers5[0] = "C#";

// array NullReferenceException
int[] numbers6 = null;
//Console.WriteLine(numbers6[0]);



// jagged array
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

// İç içe for döngüleriyle jagged array'in her elemanına erişim
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j2 = 0; j2 < jaggedArray[i].Length; j2++)
    {
        Console.Write(jaggedArray[i][j2] + " ");
    }
    Console.WriteLine(); // Her alt dizi tamamlandıktan sonra yeni satır
}



// example of jagged array
int[][] puruzluDizi = new int[][]
{
    new int[] { 0, 2, 4, 6, 8 },
    new int[] { 1923, 2023 },
    new int[] { 1, 3, 5, 7, 9, 11 }
};

foreach (int[] dizi in puruzluDizi)
{
    foreach (int eleman in dizi)
    {
        Console.Write($"{eleman} ");
    }
    Console.WriteLine();
}


// array properties
int[] yillar = new int[] { 1983, 1923, 2023 };
Console.WriteLine("yillar sabit elemanli mi?: {0}", yillar.IsFixedSize); // True
Console.WriteLine("yillar salt okunur mu?: {0}", yillar.IsReadOnly);    // False
Console.WriteLine("yillar senkronize mi?: {0}", yillar.IsSynchronized); //False
Console.WriteLine("yillar kac elemanli? (32-bit): {0}", yillar.Length); // 3
Console.WriteLine("yillar kac elemanli? (64-bit): {0}", yillar.LongLength); // 3
Console.WriteLine("yillar kac boyutlu dizi?: {0}", yillar.Rank);    // 1
Console.WriteLine("yillar hangi tip elemanlari tutuyor?: {0}", yillar.GetType()); // System.Int32[]


/********** Array methods ***************/

// Array.Sort
int[] numbers7 = { 3, 1, 4, 2 };
Array.Sort(numbers7);
// numbers is now {1, 2, 3, 4}



// Array.Reverse
int[] numbers8 = { 1, 2, 3, 4 };
Array.Reverse(numbers8);
// numbers is now {4, 3, 2, 1}



// Array.Copy
int[] source = { 1, 2, 3, 4 };
int[] destination = new int[4];
Array.Copy(source, destination, source.Length - 2);
// destination now contains {1, 2, 3, 4}



// Array.Clear
int[] numbers9 = { 1, 2, 3, 4 };
Array.Clear(numbers9, 1, 2);
// numbers is now {1, 0, 0, 4}



// Array.IndexOf
int[] numbers10 = { 1, 2, 3, 4, 2 };
int index = Array.IndexOf(numbers10, 2);
// index is 1 (first occurrence of 2)



// Array.LastIndexOf
int[] numbers11 = { 1, 2, 3, 4, 2 };
int index11 = Array.LastIndexOf(numbers11, 2);
// index is 4 (last occurrence of 2)



// Array.Exists
int[] numbers12 = { 1, 2, 3, 4 };
bool exists = Array.Exists(numbers12, element => element > 2);
// exists is true because there are elements greater than 2


// Array.Find
int[] numbers13 = { 1, 2, 3, 4 };
int result = Array.Find(numbers13, element => element > 2);
// result is 3 (the first element greater than 2)



// Array.FindAll
int[] numbers14 = { 1, 2, 3, 4 };
int[] results = Array.FindAll(numbers14, element => element > 2);
// results is {3, 4}



// Array.FindIndex
int[] numbers15 = { 1, 2, 3, 4 };
int index15 = Array.FindIndex(numbers15, element => element > 2);
// index is 2 (index of first element greater than 2)



// Array.FindLast
int[] numbers16 = { 1, 2, 3, 4 };
int result16 = Array.FindLast(numbers16, element => element > 2);
// result is 4 (the last element greater than 2)



// Array.FindLastIndex
int[] numbers17 = { 1, 2, 3, 4 };
int index17 = Array.FindLastIndex(numbers17, element => element > 2);
// index is 3 (index of last element greater than 2)



// Array.BinarySearch
int[] numbers18 = { 1, 2, 3, 4 };
int index18 = Array.BinarySearch(numbers18, 3);
// index is 2



// Array.Resize
int[] numbers19 = { 1, 2, 3, 4 };
Array.Resize(ref numbers19, 6);
// numbers now has 6 elements and is {1, 2, 3, 4, 0, 0}



// Array.Clear
int[] numbers20 = { 1, 2, 3, 4 };
int[] clonedArray = (int[])numbers20.Clone();
// clonedArray is a copy of numbers



// Array.ConstrainedCopy
// Copies elements from one array to another while ensuring type-safety and constraints.
int[] source21 = { 1, 2, 3, 4 };
int[] destination21 = new int[4];
Array.ConstrainedCopy(source21, 0, destination21, 0, 4);
// destination is now {1, 2, 3, 4}



// Array.ConvertAll
// Converts an array of one type to an array of another type.
int[] numbers22 = { 1, 2, 3, 4 };
string[] strings22 = Array.ConvertAll(numbers22, number => number.ToString());
// strings is {"1", "2", "3", "4"}



// Array.Fill
int[] numbers23 = new int[5];
Array.Fill(numbers23, 10);
// numbers is now {10, 10, 10, 10, 10}



// Array.ForEach
int[] numbers24 = { 1, 2, 3, 4 };
Array.ForEach(numbers24, number => Console.WriteLine(number));
// prints 1, 2, 3, 4



// Array.TrueForAll
int[] numbers25 = { 2, 4, 6 };
bool allEven = Array.TrueForAll(numbers25, number => number % 2 == 0);
// allEven is true since all numbers are even


