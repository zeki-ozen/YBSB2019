/********** STRUCTURED PROGRAMMING **********/
/********** Dr. Zeki Ozen *******************/
/********** WEEK 5 - Generic Collections ****/

using System;
using System.Collections.Generic;

/* Remembering arrays 
string bolum = "MIS";

string[] departments = new string[3];
departments[0] = "MIS";
departments[2] = "Economic";
departments[1] = "Business Administration";
// departments[3] = "Econometry"; // throws error

int[] deneme = new int[] { 1, 2, 5, 6, 0, 3 };

Console.WriteLine("Array sorting...");
Array.Sort(deneme); // 0 1 2 3 5 6
foreach (int number in deneme)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

Console.WriteLine("Array reversing...");
Array.Reverse(deneme); // 6 5 3 2 1 0
foreach (int number in deneme)
{
    Console.Write($"{number} ");
}
*/

/****************List<T> Collection****************/

// Defining List that integer data type

List<int> numbers = new List<int> {0, 1, 2, 3, 2 };
// Second way to define List
List<int> numbers2 = new List<int>();
// third way to define List using var
var numbers3 = new List<int>();

// Adding elements to the List
numbers.Add(4); // Adds 4 to the List

// Getting the number of elements in the List
Console.WriteLine("List has/have {0} element(s).", numbers.Count); // Output: 6


// iterating over the List
foreach (int number in numbers)
{
    Console.Write($"{number} "); // 0 1 2 3 2 4
}

Console.WriteLine();

// Removing an element from the List
numbers.Remove(2); // Removes the first element with value 2 from the List
Console.WriteLine("The first element with value 2 is deleted");
foreach (int number in numbers)
{
    Console.Write($"{number} "); // 0 1 3 2 4
}
Console.WriteLine();


Console.WriteLine("Adding elements of an array as elements using AddRange");
int[] eklenecek_dizi = new int[] { 5, -2, 7 };
// Adding elements of an array as elements using AddRange
numbers.AddRange(eklenecek_dizi);
foreach (int number in numbers)
{
    Console.Write($"{number} "); // 0 1 3 2 4 5 -2 7
}
Console.WriteLine();

Console.WriteLine("Adding elements of a List as items using AddRange");
// Adding elements of a List as items using AddRange
List<int> eklenecek_liste = new List<int> { -17, 34, -48 };
numbers.AddRange(eklenecek_liste);
foreach (int number in numbers)
{
    Console.Write($"{number} "); // 0 1 3 2 4 5 -2 7 -17 34 -48
}
Console.WriteLine();

Console.WriteLine("Accessing list elements by index (0)");
Console.WriteLine(numbers[0]); // Output: 0

Console.WriteLine("Inserting an element at a specific index (1)");
numbers.Insert(1, 10); // Inserts 10 at index 1
Console.WriteLine(numbers[1]); // Output: 10

Console.WriteLine("Removing an element at a specific index (1)");
numbers.RemoveAt(1); // Removes the element at index 1
foreach (int number in numbers)
{
    Console.Write($"{number} "); // 0 1 3 2 4 5 -2 7 -17 34 -48
}


Console.WriteLine("Search for a number (3) in the list");
if (numbers.Contains(3))
{
    Console.WriteLine("Number found in the list");
}
else
{
    Console.WriteLine("Number not found in the list");
}

// or 
bool isfound = numbers.Contains(3);
Console.WriteLine(isfound);


Console.WriteLine("Return index of a number (5) in the list");
int index = numbers.IndexOf(5); 
Console.WriteLine(index); // 5


Console.WriteLine("Finding first elements that greater than 3");
int first_greaterThan3 = numbers.Find(n => n > 3);
Console.WriteLine(first_greaterThan3);


Console.WriteLine("Finding all elemnts that greater than 3");
List<int> greaterThan3 = numbers.FindAll(n => n > 3);
foreach (int number in greaterThan3)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


// Sorting the list
Console.WriteLine("List sorting...");
numbers.Sort(); // Sorts the list in ascending order
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

// Reversing the list
Console.WriteLine("List reversing...");
numbers.Reverse(); // Reverses the list
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("List converting to array");
int[] numbersArray = numbers.ToArray();
foreach (int number in numbersArray)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Array converting to List");
string[] array = { "mouse", "keyboard", "monitor" };
List<string> numbersList = array.ToList();
foreach (string item in numbersList)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


// Lists are filexible collections but we define static size array
List<int> newList = new List<int>(3); // Initializes with a capacity of 3
newList.Add(1);
newList.Add(2);
newList.Add(3);
newList.Add(4); // No error because list is flexible.
                // it means it can grow dynamically
foreach (int number in newList)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

// Question: Define List that floating point number data type
Console.WriteLine("Defining List that floating point number data type");
List<float> ondalikli = new List<float> { 12.77899f, -34.985f, 12.56f, 34.98f, 69.3188f, 30.88f, 56.721f };
ondalikli.Add(3.14f);
// 12.77899f, -34,12.56f,34,69.3188f,30,56.721f 3
foreach (int eleman in ondalikli)
{
    Console.Write($"{eleman} ");
}
Console.WriteLine();

foreach (float eleman in ondalikli)
{
    Console.Write($"{(int)eleman} ");
}
Console.WriteLine();

for (int i = 0; i < ondalikli.Count; i++)
{
    if (i % 2 == 0)
        Console.Write($"{ondalikli[i]} ");
    else
        Console.Write($"{(int)ondalikli[i]} ");
}
Console.WriteLine();


// Clearing the list
Console.WriteLine("Removing all list elements");
numbers.Clear(); // Removes all elements from the list
Console.WriteLine("List has {0} elements.", numbers.Count); // Output: 0



/****************Dictionary<TKey, TValue> Collection****************/

Console.WriteLine("Defining a Dictionary with a predefined number of elements (3)");
// Define Dictionary that key is string and value is int
Dictionary<string, int> dictionary = new Dictionary<string, int>();


Console.WriteLine("Adding elements to the dictionary");
dictionary.Add("one", 1);
dictionary.Add("two", 2);
dictionary.Add("three", 3);
Console.WriteLine("Adding fourth element to the dictionary...");
dictionary.Add("four", 4);

// adding same key
// dictionary.Add("four", 14); // Throws an exception because the key "four" already exists in the dictionary

// Getting the number of elements in the dictionary
Console.WriteLine("Dictionary has/have {0} element(s)", dictionary.Count); // Output: 4


Console.WriteLine("Accessing dictionary elements by key 'one'");
Console.WriteLine(dictionary["one"]); // Output: 1

Console.WriteLine("Iterating over the dictionary");
foreach (KeyValuePair<string, int> item in dictionary)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
Console.WriteLine();



Console.WriteLine("Iterating over the dictionary using var");
foreach (var item in dictionary)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
Console.WriteLine();


Console.WriteLine("Searching for a key 'three' in the dictionary");
if (dictionary.ContainsKey("three"))
{
    Console.WriteLine("Key found in the dictionary");
}
else
{
    Console.WriteLine("Key not found in the dictionary");
}
Console.WriteLine();


Console.WriteLine("Searching for a value 'three' in the dictionary");
if (dictionary.ContainsValue(3))
{
    Console.WriteLine("Value found in the dictionary");
}
else
{
    Console.WriteLine("Value not found in the dictionary");
}
Console.WriteLine();


Console.WriteLine("Searching for a value 'three' in the dictionary using TryGetValue method");
int value;
if (dictionary.TryGetValue("four", out value))
{
    Console.WriteLine($"Value: {value}");
}
else
{
    Console.WriteLine("Value not found in the dictionary");
}
Console.WriteLine();


Console.WriteLine("Removing the element with key \"two\" from the dictionary");
dictionary.Remove("two");


Console.WriteLine("Getting all keys in the dictionary");
foreach (string key in dictionary.Keys)
{
    Console.WriteLine(key);
}
Console.WriteLine();


Console.WriteLine("Getting all values in the dictionary");
foreach (int val in dictionary.Values)
{
    Console.WriteLine(val);
}
Console.WriteLine();


Console.WriteLine("Getting value and key pair in the dictionary");
foreach (KeyValuePair<string, int> item in dictionary)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
Console.WriteLine();

Console.WriteLine("Getting value and key pair in the dictionary using var");
foreach (var item in dictionary)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
Console.WriteLine();




/****************Queue<T> Collection****************/
// Defining a Queue

Queue<string> tasks = new Queue<string>();
// or using var
var tasks2 = new Queue<string>();

Console.WriteLine("Adding elements to the Queue using Enqueue method.");
tasks.Enqueue("Task 1");
tasks.Enqueue("Task 2");
tasks.Enqueue("Task 3");


Console.WriteLine("Iterating over the Queue");
foreach (string item in tasks)
{
    Console.WriteLine(item);
}
Console.WriteLine();


Console.WriteLine("Removing element to the Queue using Dequeue method.");
string task = tasks.Dequeue(); // Removes and returns the first element in the queue
foreach (string item in tasks)
{
    Console.WriteLine(item);
}
Console.WriteLine();



Console.WriteLine("Getting the first element in the Queue using Peek method");
string firstTask = tasks.Peek(); // Returns the first element in the Queue without removing it
Console.WriteLine("First element: {0}", firstTask);

// Count property
Console.WriteLine("Queue has/have {0} element(s)", tasks.Count); // Output: 2


Console.WriteLine("Checking Contents of the Queue:");
if (tasks.Contains("Task 1"))
{
    Console.WriteLine("Task 1 is in the Queue");
}
else
{
    Console.WriteLine("Task 1 is not in the Queue");
}

// or
bool hasTask2 = tasks.Contains("Task 1");

// Clear method
// tasks.Clear(); // Removes all elements from the Queue




/****************Stack<T> Collection****************/
// Defining a Stack

Stack<string> plates = new Stack<string>();
// or using var
var plates2 = new Stack<string>();


Console.WriteLine("Adding elements to the Stack using Push method...");
plates.Push("Plate 1");
plates.Push("Plate 2");
plates.Push("Plate 3");


Console.WriteLine("Iterating over the Stack...");
foreach (string item in plates)
{
    Console.WriteLine(item);
}
Console.WriteLine();


Console.WriteLine("Removing element from the Stack using Pop method.");
string plate = plates.Pop(); // Removes and returns the top element in the stack
Console.WriteLine("Removed element: {0}", plate); // Output: Plate 3 removed

Console.WriteLine("Iterating over the stack...");
foreach (string item in plates)
{
    Console.WriteLine(item);
}

// Peek method (Inspecting Elements Without Removal)
Console.WriteLine("Getting the first element in the Stack using Peek method");

string topPlate = plates.Peek(); // Returns the top element in the stack without removing it
Console.WriteLine("First element: {0}", topPlate);

// Count property
Console.WriteLine("Stack has/have {0} element(s)", plates.Count); // Output: 2


Console.WriteLine("Checking Contents of the Stack:");
if (plates.Contains("Plate 1"))
{
    Console.WriteLine("Plate 1 is in the Stack");
}
else
{
    Console.WriteLine("Plate 1 is not in the Stack");
}

// or
bool hasPlate1 = plates.Contains("Plate 1");
Console.WriteLine(hasPlate1);

// Clear method
// plates.Clear(); // Removes all elements from the Stack




/****************HashSet<T> Collection****************/
// Defining a HashSet

HashSet<int> hashSetNumbers = new HashSet<int>();
// or
var hashSetNumbers2 = new HashSet<int>();

Console.WriteLine("Adding elements to the HashSet using Add method...");
hashSetNumbers.Add(1);
hashSetNumbers.Add(2);
hashSetNumbers.Add(3);
hashSetNumbers.Add(3);


Console.WriteLine("Iterating over the HashSet...");
foreach (int number in hashSetNumbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Set operations in HashSet:");
HashSet<int> setA = new HashSet<int> { 1, 2, 3 };
HashSet<int> setB = new HashSet<int> { 3, 4, 5 };
Console.WriteLine("Iterating setA...");
foreach (int number in setA)
{
    Console.Write($"{number} "); // 1, 2, 3
}
Console.WriteLine();

Console.WriteLine("Iterating setB...");
foreach (int number in setB)
{
    Console.Write($"{number} "); // 1, 2, 3
}
Console.WriteLine();

Console.WriteLine("Merging two HashSets into setA...");
setA.UnionWith(setB); // setA contains now {1, 2, 3, 4, 5}
foreach (int number in setA)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


// IntersectWith(IEnumerable<T> other): Keeps only elements present in both the current set and another collection.
Console.WriteLine("setA intersection setB:");
setA.IntersectWith(setB); // returns {3 4 5}
foreach (int number in setA)
{
    Console.Write($"{number} ");
}
Console.WriteLine();

// ExceptWith(IEnumerable<T> other): Removes all elements in the current set that are also in another collection.
Console.WriteLine("ExceptWith of two HashSets:");
setA.ExceptWith(setB); // return empty
foreach (int number in setA)
{
    Console.Write($"{number} "); 
}
Console.WriteLine();

// SymmetricExceptWith(IEnumerable<T> other): Removes all elements in the current set that are also in another collection, and adds all elements in the other collection that are not in the current set.
Console.WriteLine("SymmetricExceptWith of two HashSets:");
setA.SymmetricExceptWith(setB); // setA now contains {1, 2, 4, 5}
foreach (int number in setA)
{
    Console.Write($"{number} "); // 5 4 3
}
Console.WriteLine();





/****************LinkedList<T> Collection****************/
// Defining LinkedList

LinkedList<int> numbersLL = new LinkedList<int>();
// or
var numbers2LL = new LinkedList<int>();

Console.WriteLine("Adding elements to the LinkedList using AddFirst method...");
numbersLL.AddFirst(1);
numbersLL.AddFirst(2);
numbersLL.AddFirst(3);

Console.WriteLine("Iterating over the LinkedList");
foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Adding elements to the LinkedList using AddLast method...");
numbersLL.AddLast(4);
numbersLL.AddLast(5);
foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Adding elements to the LinkedList using AddBefore method...");
numbersLL.AddBefore(numbersLL.Find(4), 10); // Adds 10 before the element 4
foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Adding elements to the LinkedList using AddAfter method...");
numbersLL.AddAfter(numbersLL.Find(4), 20); // Adds 20 after the element 4
foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Removing element with value 4 from the LinkedList using Remove method...");
numbersLL.Remove(4); // Removes the element with value 4 from the LinkedList
foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Removing the first element from the LinkedList using RemoveFirst method...");
numbersLL.RemoveFirst(); // Removes the first element in the LinkedList

foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();


Console.WriteLine("Removing the last element from the LinkedList using RemoveLast method...");
numbersLL.RemoveLast(); // Removes the last element in the LinkedList
foreach (int number in numbersLL)
{
    Console.Write($"{number} ");
}
Console.WriteLine();



Console.WriteLine("Searching element with value 2 from the LinkedList using Find method...");
LinkedListNode<int> node = numbersLL.Find(2); // Finds the node with the value 2
Console.WriteLine(node.Value); // Output: 2


// Contains method
Console.WriteLine("LinkedList has element with value 2:");
bool has2 = numbersLL.Contains(2); // Returns true if the LinkedList contains the element 2
Console.WriteLine(has2); // Output: True


