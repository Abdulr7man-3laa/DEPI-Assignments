using System;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment_4
{
    enum DayOfWeek
    {
        Saturday = 1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Problem
            //// Method1: new int[size]
            //int[] arr1 = new int[3];
            //arr1[0] = 3;
            //arr1[1] = 4;
            //arr1[2] = 5;

            //// Method2: initializer list
            //int[] arr2 = new int[] { 3, 4, 5 };

            //// Method3: Syntax Sugar
            //int[] arr3 = { 3, 4, 5 };

            //Console.WriteLine(arr3[5]); // // IndexOutOfRangeException 
            #endregion

            #region 1st Question
            // The default value for int array elements in C# is 0.
            #endregion

            #region 2nd Problem
            //// Create two arrays
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 10, 20, 30 };

            //// Shallow copy - reference assignment
            //int[] shallowCopy = arr1;

            //Console.WriteLine("Before modification:");
            //Console.WriteLine($"arr1: [{string.Join(", ", arr1)}]");
            //Console.WriteLine($"shallowCopy: [{string.Join(", ", shallowCopy)}]");

            //// Modify original array
            //arr1[0] = 99;

            //Console.WriteLine("\nAfter modifying arr1[0] = 99:");
            //Console.WriteLine($"arr1: [{string.Join(", ", arr1)}]");
            //Console.WriteLine($"shallowCopy: [{string.Join(", ", shallowCopy)}]");

            //// Deep copy using Clone method
            //int[] deepCopy = (int[])arr2.Clone();

            //Console.WriteLine("\nBefore modification:");
            //Console.WriteLine($"arr2: [{string.Join(", ", arr2)}]");
            //Console.WriteLine($"deepCopy: [{string.Join(", ", deepCopy)}]");

            //// Modify original array
            //arr2[0] = 999;

            //Console.WriteLine("\nAfter modifying arr2[0] = 999:");
            //Console.WriteLine($"arr2: [{string.Join(", ", arr2)}]");
            //Console.WriteLine($"deepCopy: [{string.Join(", ", deepCopy)}]");
            #endregion

            #region 2nd Question
            // Array.Clone(): Creates a shallow copy of the entire array and returns an object that must be cast to the appropriate type.
            // Array.Copy(): Copies a specified number of elements from one array to another array, allowing you to specify source and destination indices and the number of elements to copy.
            #endregion

            #region 3rd Problem
            //int[,] grades = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Student {i + 1} grades:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Subject {j + 1}: {grades[i, j]}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 3nd Question
            // GetLength(dimension): Returns the number of elements in a specific dimension(e.g., GetLength(0) for rows, GetLength(1) for columns).
            // Length: Returns the total number of elements in all dimensions combined.
            #endregion

            #region 4th Problem
            //// Original array
            //int[] arr = { 5, 2, 8, 1, 9, 3 };

            //// 1. Sort method
            //Console.WriteLine("1. Array.Sort()");
            //Console.WriteLine($"Before Sort: [{string.Join(", ", arr)}]");
            //Array.Sort(arr);
            //Console.WriteLine($"After Sort: [{string.Join(", ", arr)}]");
            //Console.WriteLine();

            //// 2. Reverse method
            //Console.WriteLine("2. Array.Reverse()");
            //Console.WriteLine($"Before Reverse: [{string.Join(", ", arr)}]");
            //Array.Reverse(arr);
            //Console.WriteLine($"After Reverse: [{string.Join(", ", arr)}]");
            //Console.WriteLine();

            //// 3. IndexOf method
            //Console.WriteLine("3. Array.IndexOf()");
            //Console.WriteLine($"Array: [{string.Join(", ", arr)}]");
            //int index = Array.IndexOf(arr, 5);
            //Console.WriteLine($"Index of 5: {index}");
            //Console.WriteLine();

            //// 4. Copy method
            //Console.WriteLine("4. Array.Copy()");
            //int[] copyArr = new int[6];
            //Console.WriteLine($"Source array: [{string.Join(", ", arr)}]");
            //Console.WriteLine($"Destination before copy: [{string.Join(", ", copyArr)}]");
            //Array.Copy(arr, copyArr, arr.Length);
            //Console.WriteLine($"Destination after copy: [{string.Join(", ", copyArr)}]");
            //Console.WriteLine();

            //// 5. Clear method
            //Console.WriteLine("5. Array.Clear()");
            //Console.WriteLine($"Before Clear: [{string.Join(", ", copyArr)}]");
            //Array.Clear(copyArr, 0, copyArr.Length);
            //Console.WriteLine($"After Clear: [{string.Join(", ", copyArr)}]");
            #endregion

            #region 4th Question
            //Array.Copy(): Copies elements and if an exception occurs during copying, the destination array may be left in a partially modified state.
            //Array.ConstrainedCopy(): Ensures atomicity - if an exception occurs, the destination array remains unchanged(all-or - nothing operation).
            #endregion

            #region 5th Problem
            //int[] arr = { 10, 20, 30, 40, 50 };

            //// For loop
            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
            //Console.WriteLine();

            //// Foreach loop
            //Console.WriteLine("Using foreach loop:");
            //foreach (int x in arr) Console.WriteLine(x);
            //Console.WriteLine();

            //// While loop (reverse order)
            //Console.WriteLine("Using while loop (reverse order):");
            //int index = arr.Length - 1;
            //while (index >= 0)
            //{
            //    Console.WriteLine(arr[index]);
            //    index--;
            //}
            #endregion

            #region 5th Question
            /* Foreach is preferred for read - only operations because:
               Simpler syntax: No need to manage indices or array bounds
               Better readability: Code intention is clearer
            */
            #endregion

            #region 6th Problem
            //int number;
            //bool isValid;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    isValid = int.TryParse(Console.ReadLine(), out number);

            //    if (!isValid || number <= 0 || number % 2 == 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid Positive integer odd number.");
            //        isValid = false;
            //    }

            //} while (!isValid); 
            #endregion

            #region 6th Question
            //Input validation is important because:
            //Prevents crashes: Stops invalid data from causing runtime exceptions
            //Security: Protects against malicious input and injection attacks
            //Data integrity: Ensures only correct data enters the system
            //User experience: Provides clear feedback for incorrect inputs
            #endregion

            #region 7th Problem
            //int[,] matrix = {
            //{ 1, 2, 3 },
            //{ 4, 5, 6 },
            //{ 7, 8, 9 }
            //};

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int l = 0; l < matrix.GetLength(1); l++) Console.Write(matrix[i, l] + " ");
            //    Console.WriteLine();
            //} 
            #endregion

            #region 7th Question
            // Using For Each Loop
            #endregion

            #region 8th Problem
            //Console.Write("Enter a month number (1-12): ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //// Using if-else statement
            //string monthName1;
            //if (monthNumber == 1)      monthName1 = "January";
            //else if (monthNumber == 2) monthName1 = "February";
            //else if (monthNumber == 3) monthName1 = "March";
            //else if (monthNumber == 4) monthName1 = "April";
            //else if (monthNumber == 5) monthName1 = "May";
            //else if (monthNumber == 6) monthName1 = "June";
            //else if (monthNumber == 7) monthName1 = "July";
            //else if (monthNumber == 8) monthName1 = "August";
            //else if (monthNumber == 9) monthName1 = "September";
            //else if (monthNumber == 10) monthName1 = "October";
            //else if (monthNumber == 11) monthName1 = "November";
            //else if (monthNumber == 12) monthName1 = "December";
            //else monthName1 = "Invalid month";

            //Console.WriteLine($"Month: {monthName1}");

            //// Using switch statement
            //string monthName2;
            //switch (monthNumber)
            //{
            //    case 1:
            //        monthName2 = "January";
            //        break;
            //    case 2:
            //        monthName2 = "February";
            //        break;
            //    case 3:
            //        monthName2 = "March";
            //        break;
            //    case 4:
            //        monthName2 = "April";
            //        break;
            //    case 5:
            //        monthName2 = "May";
            //        break;
            //    case 6:
            //        monthName2 = "June";
            //        break;
            //    case 7:
            //        monthName2 = "July";
            //        break;
            //    case 8:
            //        monthName2 = "August";
            //        break;
            //    case 9:
            //        monthName2 = "September";
            //        break;
            //    case 10:
            //        monthName2 = "October";
            //        break;
            //    case 11:
            //        monthName2 = "November";
            //        break;
            //    case 12:
            //        monthName2 = "December";
            //        break;
            //    default:
            //        monthName2 = "Invalid month";
            //        break;
            //}

            //Console.WriteLine($"Month: {monthName1}"); 
            #endregion

            #region 8th Question
            //Prefer switch statement over if-else when:

            //Multiple discrete values: Comparing one variable against many specific values
            //Better readability: Cleaner syntax for many equality comparisons
            //Performance: Compiler can optimize switch statements better
            #endregion

            #region 9th Problem
            //int[] arr = { 5, 2, 8, 1, 9, 3, 5, 7 };

            //Console.WriteLine($"Original array: [{string.Join(", ", arr)}]");

            //Array.Sort(arr);
            //Console.WriteLine($"Sorted array: [{string.Join(", ", arr)}]");

            //int searchValue = 5;

            //int firstIndex = Array.IndexOf(arr, searchValue);
            //Console.WriteLine($"First occurrence of {searchValue}: {firstIndex}");

            //int lastIndex = Array.LastIndexOf(arr, searchValue);
            //Console.WriteLine($"Last occurrence of {searchValue}: {lastIndex}"); 
            #endregion

            #region 9th Question
            // The time complexity of Array.Sort() is O(n log n)
            #endregion

            #region 10th Problem
            //int[] arr = { 10, 20, 30, 40, 50 };

            //int sum1 = 0;
            //for (int i = 0; i < arr.Length; i++) sum1 += arr[i];
            //Console.WriteLine($"Sum using for loop: {sum1}");

            //int sum2 = 0;
            //foreach (int element in arr) sum2 += element;
            //Console.WriteLine($"Sum using foreach loop: {sum2}"); 
            #endregion

            #region 10th Question
            //For arrays, foreach is generally more efficient because:
            //Direct element access: Doesn't need index calculations
            //Compiler optimization: Better optimization opportunities for the JIT compiler 
            #endregion

            #region Part Two (Question 2)
            //Console.Write("Enter a number (1-7): ");
            //int input = int.Parse(Console.ReadLine());

            //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());
            //Console.WriteLine($"Day: {day}");
            #endregion

            #region Part Two (Question 3)
            //Input  0 → Output: Day:  0(not a valid day name)
            //Input  8 → Output: Day:  8(not a valid day name)
            //Input -5 → Output: Day: -5(not a valid day name)
            #endregion

        }
    }
}
