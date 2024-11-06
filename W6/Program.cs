/********** STRUCTURED PROGRAMMING **********/
/********** Dr. Zeki Ozen *******************/
/********** WEEK 6 - Non-Generic Collections ****/


using System.Collections;


/****************ArrayList Collection****************/

//ArrayList is a non-generic collection class. It can store elements of any data types. It is similar to an array, but it can grow in size automatically. It is a dynamic collection of objects that can be resized. It is found in the System.Collections namespace.

// Define an ArrayList
ArrayList arrayList = new ArrayList();

// Defining an ArrayList with initial elements
ArrayList arrayList1 = new ArrayList() { 15, "Test", false, 3.14f, 5_000_000m, -12.3E-6 };

// Defining with element size
ArrayList arrayList6 = new ArrayList(5);

// or simply using the new keyword
ArrayList arrayList2 = new();

// or using var
var arrayList3 = new ArrayList();

// or using object
object arrayList4 = new ArrayList();

// or using dynamic
dynamic arrayList5 = new ArrayList();

// Add elements to the ArrayList
arrayList.Add(1);
arrayList.Add("Two");
arrayList.Add(3.0);
arrayList.Add(true);
arrayList.Add(false);
arrayList.Add(4.0f);
arrayList.Add(5.0m);
arrayList.Add('6');


Console.WriteLine("Accessing ArrayList elements by index (0)");
Console.WriteLine(arrayList[0]);



Console.WriteLine("Iterating through the ArrayList");
// Be aware that we use the var keyword here not to specify the type of the item
foreach (var item in arrayList)
{
    Console.Write($"{item} ");
}
Console.WriteLine();


// Counting elements
Console.WriteLine("ArrayList has {0} element(s).", arrayList.Count);

// Capacity of the ArrayList
Console.WriteLine("ArrayList capacity is ", arrayList.Capacity);


// Adding elements using AddRange method
Console.WriteLine("Adding elements using AddRange method...");
arrayList.AddRange(new object[] { "mouse", 3, false });

Console.WriteLine("Inserting an element at a specific index (1)");
arrayList.Insert(1, "keyboard");

// Removing elements
Console.WriteLine("Removing an element with value Two");
arrayList.Remove("Two");

Console.WriteLine("Removing an element at a specific index (1)");
arrayList.RemoveAt(1);

// Removing all elements
// arrayList.Clear();


Console.WriteLine("Checking spesific element exists");
Console.WriteLine(arrayList.Contains("mouse"));

// Unboxing elements from the ArrayList
int firstElement = (int)arrayList[0];
bool isTrue = (bool)arrayList[3];
Console.WriteLine(isTrue);

// Trying to unbox a wrong type
// int wrongElement = (int)arrayList[1]; // This will throw an InvalidCastException


// Boxing elements to the ArrayList
arrayList.Add((object)7);

// output the last element




/****************HashTable Collection****************/
// Define a Hashtable
Hashtable hashtable = new Hashtable();
// or simply using the new keyword
Hashtable hashtable1 = new();
// or using var
var hashtable2 = new Hashtable();
// or using object
object hashtable3 = new Hashtable();
// or using dynamic
dynamic hashtable4 = new Hashtable();

// Add elements to the Hashtable
dynamic dept = new Hashtable();
dept.Add("IT", "Information Technologies");
dept.Add("HR", "Human Resources");
dept.Add("FIN", "Finance");
dept.Add("MKT", "Marketing");
// dept.Add("MKT", "Marketing"); // Throws error due to duplicate the key

// Accessing elements by key
Console.WriteLine("Accessing Hashtable elements by key");
Console.WriteLine(dept["IT"]);

// Iterating through the Hashtable
Console.WriteLine("Iterating through the Hashtable");
foreach (DictionaryEntry item in dept)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("Iterating through the Hashtable using var");
foreach (var entry in dept)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

Console.WriteLine("Iterating through the Hashtable using string");
foreach (string anahtar in dept.Keys)
    Console.WriteLine(anahtar + ": " + dept[anahtar]);


// Counting elements
Console.WriteLine("Hashtable has {0} element(s).", dept.Count);

// Checking if a key exists
Console.WriteLine("Checking if a key exists");
Console.WriteLine(dept.Contains("HR"));

// Checking if a key exists. Equivalent to Contains method
Console.WriteLine("Checking if a key exists");
Console.WriteLine(dept.ContainsKey("HR"));

// Checking if a value exists
Console.WriteLine("Checking if a value exists");
Console.WriteLine(dept.ContainsValue("Finance"));

// Removing an element by key
Console.WriteLine("Removing an element by key");
dept.Remove("HR");

// Clearing the Hashtable
// dept.Clear();


/****************Queue Collection****************/

// Define a Queue
Queue queue = new Queue();
// or simply using the new keyword
Queue queue1 = new();
// or using var
var queue2 = new Queue();
// or using object
object queue3 = new Queue();
// or using dynamic
dynamic queue4 = new Queue();

// Enqueue elements to the Queue
queue.Enqueue(1);
queue.Enqueue("Two");
queue.Enqueue(3.0);
queue.Enqueue(true);
queue.Enqueue(false);
queue.Enqueue(4.0f);
queue.Enqueue(5.0m);
queue.Enqueue('6');

// Accessing elements by index
Console.WriteLine("Accessing Queue elements by index (0)");
Console.WriteLine(queue.Peek());

// Iterating through the Queue
Console.WriteLine("Iterating through the Queue");
foreach (var item in queue)
{
    Console.WriteLine($"{item} ");
}
Console.WriteLine();


// Iterating through the Queue
Console.WriteLine("Iterating through the Queue");
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}



// Can I add an element to the Queue after Dequeue?
queue.Enqueue("New Element");

// Can I add duplicate elements to the Queue?
queue.Enqueue("New Element");

foreach (var item in queue)
{
    Console.WriteLine($"{item} ");
}

// Can I add null elements to the Queue?
queue.Enqueue(null);

// Can I remove specific element from the Queue?
// ?


// Can I add ArrayList to the Queue?
// Cretae an ArrayList with mixed data types
ArrayList mixedList = new ArrayList() { 1, "Two", 3.0, true, false, 4.0f, 5.0m, '6' };
// ?









/****************Stack Collection****************/
// Define a Stack
Stack stack = new Stack();
// or simply using the new keyword
Stack stack1 = new();
// or using var
var stack2 = new Stack();
// or using object
object stack3 = new Stack();
// or using dynamic
dynamic stack4 = new Stack();


// Push elements to the Stack
stack.Push(1);
stack.Push("Two");
stack.Push(3.0);
stack.Push(true);
stack.Push(false);
stack.Push(4.0f);
stack.Push(5.0m);
stack.Push('6');

// Accessing elements by index
Console.WriteLine("Accessing Stack elements by index (0)");
Console.WriteLine(stack.Peek());
stack.Pop();

// Iterating through the Stack
Console.WriteLine("Iterating through the Stack");
foreach (var item in stack)
{
    Console.WriteLine($"{item} ");
}
Console.WriteLine();


// Accessing elements by index
Console.WriteLine("Accessing Stack elements by index (0)");
Console.WriteLine(stack.Peek());


// Remove and retrive elements from the Stack
Console.WriteLine("Removing and retriving elements from the Stack");
//string removed_item = (string)stack.Pop();
//Console.WriteLine(removed_item);


// Checking if an element exists
Console.WriteLine("Checking if an element exists");
Console.WriteLine(stack.Contains("Two"));


// Can I add an ArrayList to the Stack?
// Creating an ArrayList with mixed data types
ArrayList mixedList2 = new ArrayList() { 1, "Two", 3.0, true, false, 4.0f, 5.0m, '6' };

// Adding the ArrayList to the Stack
// Create a stack
Stack stack5 = new Stack();

foreach (var item in mixedList2)
{
    stack5.Push(item);
}

// or
Stack stack6 = new Stack();
stack6.Push(mixedList2);

// or 
Stack stck7 = new Stack(mixedList2);


// Can I add null elements to the Stack?
// ?

// Can I remove specific element from the Stack?
// ?

// Can I add duplicate elements to the Stack?
// ?

// Can I add an element to the Stack after Pop?
// ?

// Can I add an element to the Stack after Peek?
// ?




/****************SortedList Collection****************/
// Define a SortedList
SortedList sortedList = new SortedList();
// or simply using the new keyword
SortedList sortedList1 = new();
// or using var
var sortedList2 = new SortedList();
// or using object
object sortedList3 = new SortedList();
// or using dynamic
dynamic sortedList4 = new SortedList();

// Add elements to the SortedList
sortedList.Add(1, "One");
sortedList.Add(2, "Two");
sortedList.Add(3, "Three");
sortedList.Add(4, "Four");
sortedList.Add(5, "Five");


// Accessing elements by key
Console.WriteLine("Accessing SortedList elements by key");
Console.WriteLine(sortedList[1]);

// Iterating through the SortedList
Console.WriteLine("Iterating through the SortedList");
foreach (DictionaryEntry item in sortedList)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
Console.WriteLine();


// Can I create a SortedList which has string keys and int values?
// ?

// Can I add duplicate elements to the SortedList?
// ?



// How sortedList does sort the elements? Ascending or Descending?
// ?

// Can I add duplicate keys to the SortedList?
// ?

// Can I add null keys to the SortedList?
// ?

// Can I add null values to the SortedList?
// ?

// Can I remove an element by key?
sortedList.Remove(1);

// Can I remove an element by value?
// ?







/****************BitArray Collection****************/

// Define a BitArray
BitArray bitArray = new BitArray(10);  // Creates a BitArray of 10 bits, all set to false
// or simply using the new keyword
BitArray bitArray1 = new BitArray(10);


// Define a BitArray with initial values
// Be awere the data type of the array should be bool
bool[] bits = { true, false, true, false, true, false, true, false, true, false };

// Accessing elements by index
Console.WriteLine("Accessing BitArray elements by index (0)");
Console.WriteLine(bits[0]);


// Remove an element by index
// ?

// Add an element by index
// ?

// Can I add null element to the BitArray?
// ?



// Adding Integers to the BitArray
int number = 5;
BitArray bits2 = new BitArray(number); // Creates a BitArray with bits 1, 0, 1
// Iterating through the BitArray
Console.WriteLine("Iterating through the BitArray");
for (int i = 0; i < bits2.Length; i++)
{
    Console.WriteLine(bits2[i]);
}


// Adding array of integers to the BitArray
// ?



