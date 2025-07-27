using System;

namespace Assignment2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1st Problem
            /*
            * Basic Code: declare two integer variables, calculates their sum,
            * and displays the result to the console.
            */
            //int x = 10; // Declare Variable x = 10
            //int y = 20; // Declare Variable y = 20
            //int sum = x + y; // Calc Sum Of x + y = 30
            //Console.WriteLine(sum); // Print Result of sum 
            #endregion

            #region 1st Question
            // Comment Shortcut: CTRL + K + C
            // Uncomment Shortcut: CTRL + K + U
            #endregion

            #region 2nd Problem
            // Error is:
            //          1. u declare int and assign string value to it
            //          3. u write console instead of Console -> C# is Case sensitive
            //          2. and u sum x + y without declare y variable
            // Correct Code:
            //int x = 10;
            //Console.WriteLine(x);
            #endregion

            #region 2nd Question
            /*
                 * Logical Error: Programe Works Will But Returns Wrong Results, For Example ur result required to divided by 10 in final calc but u didn't
                 * Runtime Error: Occurs on Runtime, Code Looks Right, Syntax Right, But There's Somthing Happen, For example Dividing by 0
                */
            #endregion

            #region 3rd Problem
            //string FullName = "Abdulrhman Alaa";
            //int Age = 10;
            //float Salary = 1000.50f;
            //bool isStudent = true;
            #endregion

            #region 3rd Question
            // For Code Readability and Consistency 
            #endregion

            #region 4th Problem
            //Person person1 = new Person { Name = "Abdulrhman", Age = 20 };

            //person1.Name = "MOhamed";
            //person1.Age = 23;

            //// Both changed 
            #endregion

            #region 4th Question
            /*
                 * Value Type: Stack Allocation -> INT, FLOAT, DOUBLE, BOOL, CHAR
                 * Reference Type: Heap Allocation -> CLASS, OBJECT, STRING
                 */
            #endregion

            #region 5th Problem
            //int x = 15;
            //int y = 4;
            //int sum = x + y;
            //int difference = x - y;
            //int product = x * y;
            //double division = (double)x / y;
            //int remainder = x % y;
            #endregion

            #region 5th Question
            //int a = 2, b = 7;
            //Console.WriteLine(a % b); // 2 -> BCZ a is smaller Than b 
            #endregion

            #region 6th Problem
            //int x = int.Parse(Console.ReadLine());

            //if (x > 10 && x % 2 == 0) Console.WriteLine("yes");
            //else Console.WriteLine("no");
            #endregion

            #region 6th Question
            // && -> Logical Operator -> AND -> Works with bool (True / False) -> Short-circuit (stops if first condition is false)
            // &  -> Bitwise Operator -> AND -> Works with bits (Binary)       -> Long-circuit  
            #endregion

            #region 7th Problem
            //double doubleValue = double.Parse(Console.ReadLine());
            //int explicitCast = (int)doubleValue; // Explicit Casting
            //int implicitCast = explicitCast;     // Implicit Casting
            //Console.WriteLine(explicitCast);
            //Console.WriteLine(implicitCast); 
            #endregion

            #region 7th Question
            // Explicit casting is required when converting a double to in bcz the conversion may loss some of data, so we need to make sure first
            #endregion

            #region 8th Problem
            //string x = Console.ReadLine();
            //int age = int.Parse(x);
            //if (age > 0) Console.WriteLine("Valid age: " + age);
            //else Console.WriteLine("Invalid age!"); 
            #endregion

            #region 8th Question
            // If the input invalid - Example: User enters "DDD" in int Variable, and it's called runtime error, we can handle it using try, catch
            #endregion

            #region 9th Problem
            //int x = 7;
            //Console.WriteLine(++x); // Prefix -> add 1 first them display
            //Console.WriteLine(x++); // Postifix -> Display first then add 1 
            #endregion

            #region 9th Question
            //int x = 5;
            //int y = ++x + x++; // First we add 1 to (x = 5) so it will be 6, Then we sum x which is already 6 Then = 12, then we add 1 to x
            //Console.WriteLine(y); // 12
            #endregion

        }
    }
}
