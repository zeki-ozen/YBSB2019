/********** STRUCTURED PROGRAMMING II **********/
/********** Dr. Zeki Ozen *********************/
/********** WEEK I - Reference Data Types *****/

namespace w1_str2
{
    internal class Program
    {
        static void Main(string[] args)
        {




            /*
            int x = 5; // integer data type
            int y = x;

            x = 10;
            Console.WriteLine("x: {0}, y: {1}", x, y);


            // crete an array of integers
            int[] arr = {1,2,3,4,5 };
            int[] arr2 = arr;

            arr[0] = 10;
            Console.WriteLine("arr[0]: {0}, arr2[0]: {1}", arr[0], arr2[0]);


            int sayi;
            // Console.WriteLine(sayi); // Error: Use of unassigned local variable 'sayi'
            */

            /*
            // prorotype of string data type
            string varible_name;  // not assigned a value when declarin it
            string varible_name2 = "C# Programming";
            varible_name = "Structured programming II";


            // string data type
            string courseName = "Structured Programming II ";
            Console.WriteLine(courseName.Length);  // 26
            Console.WriteLine(courseName.Substring(11, 7));  // Program
            Console.WriteLine(courseName.Contains("C#"));  // False

            // use dot notation to see string methods
            // courseName.

            string courseName2 = courseName;
            courseName = "C# Programming II";
            Console.WriteLine(courseName2);  // Structured Programming II



            // proof that string acts as a value type



            */
            // compiler knows the data type of the variables
            //int sayi = 2024;
            //int sayi = "2024bvn";











            // object data type
            /*
            object obj; // it is not mandatory to assign a value when declaring an object variable
            obj = 5; // value can be assigned later
            Console.WriteLine("object variable: {0}", obj);
            Console.WriteLine("Data type: {0}", obj.GetType());
            Console.WriteLine("------------");
            // obj++; // throws an error.
            // obj = obj + 1; // throws an error.
           

            object obj = 5;
            obj = (int)obj + 1;
            Console.WriteLine("object variable: {0}", obj);
            Console.WriteLine("Data type: {0}", obj.GetType());
            obj = "C#"; // data type can be changed later
            Console.WriteLine("object variable: {0}", obj);
            Console.WriteLine("Data type: {0}", obj.GetType());
            Console.WriteLine("------------");

           /*
            // byte sayi = null;
            object y = null;    // valid. may take null value
            object z = 2022, w = "Zeki";  // valid. may assign multiple variables at once
            Console.WriteLine("y: {0}, z: {1}, w: {2}", y, z, w);
            Console.WriteLine("------------");

            
            
            object z1 = "Test";
            object z2 = z1;

            //Console.WriteLine("z1: {0}, z2: {1}", z1, z2);
            z1 = "New Test";
            Console.WriteLine("z1: {0}, z2: {1}", z1, z2);
            Console.WriteLine("------------");


            /*
            // boxing
            int x = 5;
            object obj2 = x; // boxing
            Console.WriteLine("x: {0}, obj2: {1}", x, obj2);
            Console.WriteLine("Data type of x: {0}", x.GetType());
            Console.WriteLine("Data type of obj2: {0}", obj2.GetType());
            Console.WriteLine("------------");

            /*
            // unboxing
            object obj2 = 5;
            int y2 = (int)obj2; // unboxing
            Console.WriteLine("y2: {0}, obj2: {1}", y2, obj2);
            Console.WriteLine("Data type of y2: {0}", y2.GetType());
            Console.WriteLine("Data type of obj2: {0}", obj2.GetType());
            Console.WriteLine("------------");

            /*
            // toString method in object class
            int x2 = 5;
            object obj3 = x2;
            Console.WriteLine("x2: {0}, obj3: {1}", x2, obj3);










            /*
            // dynamic data type
            dynamic d = 5;
            Console.WriteLine("d: {0}", d);
            Console.WriteLine("Data type of d: {0}", d.GetType());
            d = "C#";
            Console.WriteLine("d: {0}", d);
            Console.WriteLine("Data type of d: {0}", d.GetType());
            Console.WriteLine("------------");
            dynamic ders = new { ClassNmae = "Structured Programmming", credit =3 };
            Console.WriteLine("d: {0}", d);
            Console.WriteLine("Name: {0}, Age: {1}", ders.ClassNmae, ders.credit);
            Console.WriteLine("------------");

            dynamic deneme_degiskeni = null;
            dynamic deneme_degiskeni2 ;

            /*
            dynamic number = 5;
            Console.WriteLine(number + 10);  // Output: 15

            number = "Five";
            Console.WriteLine(number + " is the value");  // Output: Five is the value










            */

            // var data type
            var x3 = 5;
            Console.WriteLine("x3: {0}", x3);
            Console.WriteLine("Data type of x3: {0}", x3.GetType());
            // x3 = "C#"; // throws an error
            Console.WriteLine("------------");

            /*
            var y3 = "C#";
            Console.WriteLine("y3: {0}", y3);
            Console.WriteLine("Data type of y3: {0}", y3.GetType());
            // y3 = 5; // throws an error

            var z3 = new { Name = "Structured Programming", Credit = 3 };
            Console.WriteLine("Name: {0}, Credit: {1}", z3.Name, z3.Credit);


            */


            // var ornek_degisken; // throws an error because var must be initialized when declared
            // var ornek_degisken2 = null; // throws an error because var must be initialized when declared

            var ornek_degisken3 = 5;
            ornek_degisken3 = "C#"; // throws an error because var is implicitly typed  
        }
    }
}
