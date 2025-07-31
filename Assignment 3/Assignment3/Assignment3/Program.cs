using System;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Person
    {
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Problem
            //string input = Console.ReadLine();
            //try
            //{
            //    int result1 = int.Parse(input);
            //    Console.WriteLine("Using int.Parse: " + result1);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("int.Parse Error: " + ex.Message);
            //}

            //// Using Convert.ToInt32
            //try
            //{
            //    int result2 = Convert.ToInt32(input);
            //    Console.WriteLine("Using Convert.ToInt32: " + result2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Convert.ToInt32 Error: " + ex.Message);
            //}
            #endregion

            #region 1st Question
            // int.Parse         ->>  Not safe with null values
            //  Convert.ToInt32  ->>  Safe with null values
            #endregion

            #region 2nd Problem
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int result))
            //{
            //    Console.WriteLine("You entered: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region 2nd Question
            /*
                 * TryParse: does not throw exceptions on failure
                 * Instead, it returns false, making it much faster and more efficient
            */
            #endregion

            #region 3rd Problem
            //object obj;

            //// int
            //obj = 42;
            //Console.WriteLine("int value: " + obj);
            //Console.WriteLine("GetHashCode: " + obj.GetHashCode());

            //// string
            //obj = "Hello";
            //Console.WriteLine("\nstring value: " + obj);
            //Console.WriteLine("GetHashCode: " + obj.GetHashCode());

            //// double
            //obj = 3.14;
            //Console.WriteLine("\ndouble value: " + obj);
            //Console.WriteLine("GetHashCode: " + obj.GetHashCode());
            #endregion

            #region 3rd Question
            // method used to generate a numeric hash code that represents the current object
            // It helps decide where an object should be stored 
            #endregion

            #region 4th Problem
            //Person person1 = new Person();
            //person1.Name = "Ahmed";

            //Person person2 = person1;

            //person2.Name = "Medo";

            //Console.WriteLine("person1.Name: " + person1.Name); // Outputs: Medo
            //Console.WriteLine("person2.Name: " + person2.Name); // Outputs: Medo
            #endregion

            #region 4th Question
            // Reference equality means two variables point to the same memory location — Ex: they are the same object instance.
            #endregion

            #region 5th Problem
            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //message += " Hi Willy";

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            #endregion

            #region 5th Question
            // A string is immutable: meaning once created, it cannot be changed. Any operation that modify a string actually creates a new string in memory.
            #endregion

            #region 6th Problem
            //StringBuilder x = new StringBuilder("Hi Willy");

            //Console.WriteLine(x.ToString());
            //Console.WriteLine(x.GetHashCode());

            //x.Append(" - Welcome back!");

            //Console.WriteLine(x.ToString());
            //Console.WriteLine(x.GetHashCode());
            #endregion

            #region 6th Question
            // BCZ: allowing in-place modifications without creating new string objects
            #endregion

            #region 7th Question
            // StringBuilder is faster for large-scale string modifications because it uses a dynamic buffer to modify strings in place, avoiding repeated memory allocations and copying.
            #endregion

            #region 8th Problem
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int sum = input1 + input2;

            // Concatenation
            Console.WriteLine("Sum is " + input1 + " + " + input2 + " = " + sum);

            // Formatting
            Console.WriteLine(string.Format("Sum is {0} + {1} = {2}", input1, input2, sum));

            // Interpolation
            Console.WriteLine($"Sum is {input1} + {input2} = {sum}");
            #endregion

            #region 8th Question
            // interpolation ($"...") is the most used because it is more readable
            #endregion

            #region 9th Problem
            //StringBuilder sb = new StringBuilder("Hello");

            //// Append text
            //sb.Append(" Ahmed!");
            //Console.WriteLine(sb.ToString());

            //// Replace a substring
            //sb.Replace("Ahmed", "Adam");
            //Console.WriteLine(sb.ToString());

            //// Insert a string at a specific position
            //sb.Insert(0, "Hey, ");
            //Console.WriteLine(sb.ToString());

            //// Remove a portion of text
            //sb.Remove(4, 2); // Removes ", "
            //Console.WriteLine(sb.ToString());
            #endregion

            #region 9th Question
            // StringBuilder uses a dynamic buffer that allows in-place edits, avoiding the constant memory allocations required by immutable strings.
            #endregion
        }
    }
}
