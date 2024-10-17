/********** STRUCTURED PROGRAMMING II **********/
/********** Dr. Zeki Ozen *******************/
/********** WEEK 3 - ARRAYS *****************/


using System;
// Create an array of string with 5 elements
string[] stringDizi = new string[5];

// Create an array of integer with 5 elements
int[] integerArray = new int[5];

// assign 5 elements to the string array
stringDizi[0] = "Mouse";
stringDizi[1] = "Keyboard";
stringDizi[2] = "Monitor";
stringDizi[3] = "Headphones";
stringDizi[4] = "Microphone";




// Print the second elemnt of the given array
int[] numbers = { 1, 2, 3, 4, 5 };


// Print the last element of the given array
// Expected Output: 5
// Console.WriteLine(numbers[numbers.Length - 1]);


// print count of the elements in the array
// Expected Output: 5
// Console.WriteLine(numbers.Length );


// print the rank of the array
// Expected Output: 1
// Array.Rank
// Console.WriteLine(numbers.Rank);


// print the thirth element of the array
// Expected Output: 3
// Console.WriteLine(numbers[2]); 

// Second way to get the thirth element of the array is using GetValue method
// Array.GetValue
// Expected Output: 3
// Console.WriteLine(numbers.GetValue(2));


// change the thirth element to 11
// Expected Output: 1 2 11 4 5
/*
numbers[2] = 11;

// second way to change the thirth element to 11 is using SetValue method
numbers.SetValue(11, 2);

Console.WriteLine(numbers);
*/
int[] numbers2 = { 12, 3, 9, -2, 6, 3, 58, -4 };
// Checks if the array has a value of 3
// Expected Output: True
// Use Exists method
/*
bool status = Array.Exists(numbers2, element => element == 3);
bool status2 = false;
for(int i = 0; i < numbers2.Length; i++)
{
    if(numbers2[i] == 3)
    {
        status2 = true;
        break;
    }
*/
// syntax of the Lambda function
// x => x condition
// x => x < 3
// x = x == "MIS"

// var result = Array.Exists(numbers2, element => element == 3); // true
// Console.WriteLine(result); // True



// Find the first values that are greater than 5 in the array
// Expected Output: 12
// Use Find method
// Array.Find(numbers2, x => x > 5);


// Find the last values that are greater than 5 in the array
// Expected Output: 58
// Use FindLast method



// Find the all values that are greater than 5 in the array
// Expected Output: 12 9 6 58
// Use FindAll method
/*
int[] donenDegerler = Array.FindAll(numbers2, x => x > 5);

foreach (var item in donenDegerler){
    Console.WriteLine(item);
}
*/
// find the first index of elements greater than 15 in the array
// Use FindIndex method
// Expected Output: 6



// find the last index of elements less than zero in the array
// Use FindLastIndex method
// Expected Output: 7




// Find the first index in the array where the element with value 3 is located
// Use IndexOf method
// Expected Output: 1




// checks all elements in the array are greater than 0
// Use TrueForAll method
// Expected Output: False
// bool greaterthan5 = Array.TrueForAll(numbers2, element => element > -5); // false
// Console.WriteLine(greaterthan5);




// Iterate through the array and print the value of each element
/*
int[] numbers3 = { 1, 2, 3, 4, 5 };
// using for loop
for (int i = 0; i < numbers3.Length; i++)
{
    Console.WriteLine(numbers3[i]);
}

// using foreach loop
foreach (int element in numbers3)
{
    Console.WriteLine(element);
}
*/

// Print the length of the array
// Expected Output: 4








int bolunen = 38;
int bolen = 13;
double sonuc = (bolunen) / (double)(bolen);
Console.WriteLine(sonuc);




int[] sayilar = { 3, 1, 2, 3, 4, 5, 3, 4, 3, 2, 3, 2, 3 };
// find the quantity/frequence of the number 3 in the array
// Expected Output: 6
int tekrar = 0;


// find odd and even number quantities in the array
int tekSayilarinAdedi = 0;
int ciftSayilarinAdedi = 0;
/*
foreach (int sayi in sayilar)
{
    if (sayi % 2 == 0)
        ciftSayilarinAdedi++;
    else
        tekSayilarinAdedi++;
}
Console.WriteLine("Tek sayilar {0}, Çift Sayılar {1} adet", tekSayilarinAdedi, ciftSayilarinAdedi);
*/

// find the averege of the elements in the array

int[] number3 = { 13, 5, 8, 22, 36, -12, -7 };

// find the difference between the maximum and minimum values in the array

int[] dizi1 = {3, 8, 11, 5, 16};
int[] dizi2 = {4, 7, 9, 3, 12};
// 7 15 20 8 28
/*
int[] toplamDizi = new int[dizi1.Length];
for (int i = 0; i < dizi1.Length; i++){
    toplamDizi[i] = dizi1[i] + dizi2[i];
}

foreach (int item in toplamDizi){
    Console.Write($"{item} ");
}
*/
