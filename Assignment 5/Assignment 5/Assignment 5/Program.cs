using System;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Problem
            //try
            //{
            //    Console.Write("Enter first integer: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second integer: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero!");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}
            #endregion

            #region 1st Question
            // Finally block: execute code that must run regardless of whether an exception occurs or not.
            #endregion

            #region 2nd Problem
            //public static void TestDefensiveCode()
            //{
            //    int X, Y, Z;

            //    do
            //    {
            //        Console.WriteLine("Enter First Number: ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

            //    do
            //    {
            //        Console.WriteLine("Enter Second Number: ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            //    Z = X / Y;

            //    int[] arr = { 1, 2, 3 };
            //    if (arr?.Length > 98)
            //        arr[98] = 76;
            //}
            #endregion

            #region 2nd Question
            // int.TryParse() improves program robustness compared to int.Parse() because:
            // Returns false for invalid input instead of throwing FormatException
            // Allows checking validity before using the parsed value
            // Prevents program crashes from invalid user input
            #endregion

            #region 3rd Problem
            //int? x = null;
            //int result = x ?? 100;

            //Console.WriteLine($"HasValue: {x.HasValue}");

            //if (x.HasValue) Console.WriteLine($"Value: {x.Value}");
            //else Console.WriteLine("Variable is null");

            //x = 50;
            //Console.WriteLine($"HasValue: {x.HasValue}");
            //Console.WriteLine($"Value: {x.Value}");

            //try
            //{
            //    x = null;
            //    int y = x.Value;
            //}
            //catch (InvalidOperationException)
            //{
            //    Console.WriteLine($"Exception");
            //}
            #endregion

            #region 3rd Question
            // When trying to access Value on a null Nullable, an InvalidOperationException occurs"
            #endregion

            #region 4th Problem
            //int[] arr = new int[5] { 10, 20, 30, 40, 50 };

            //try
            //{
            //    Console.WriteLine(arr[10]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine($"Exception");
            //}
            #endregion

            #region 4th Question
            // Because Accessing invalid indices throws IndexOutOfRangeException
            #endregion

            #region 5th Problem
            //int[,] matrix = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter value for [{i}][{j}]: ");
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < 3; j++) rowSum += matrix[i, j];
            //}

            //for (int j = 0; j < 3; j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < 3; i++) colSum += matrix[i, j];
            //}
            #endregion

            #region 5th Question
            // GetLength(0): Returns number of rows -- GetLength(1): Returns number of columns
            #endregion

            #region 6th Problem
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2];  // Row 0: 2 elements
            //jaggedArray[1] = new int[4];  // Row 1: 4 elements
            //jaggedArray[2] = new int[3];  // Row 2: 3 elements

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"Enter {jaggedArray[i].Length} values for row {i}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"Element [{i}][{j}]: ");
            //        jaggedArray[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Print all values row by row
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++) Console.Write(jaggedArray[i][j] + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region 6th Question
            // Jagged arrays: Each row is allocated separately in different memory locations
            // Rectangular arrays: All elements are allocated in one contiguous block of memory
            #endregion

            #region 7th Problem
            //string? x = null;

            //Console.Write("Enter 'yes' to assign a value: ");
            //string input = Console.ReadLine()!;

            //if (input == "yes") x = "Hello, World!";

            //if (x != null)Console.WriteLine($"Value: {x}");
            //else Console.WriteLine("String is null");

            //Console.WriteLine($"Length: {x!.Length}");
            #endregion

            #region 7th Question
            // Helps identify potential null reference issues at compile-time
            #endregion

            #region 8th Problem
            //// Boxing
            //int value = 123;
            //object boxedValue = value;
            //Console.WriteLine($"Original value: {value}");
            //Console.WriteLine($"Boxed value: {boxedValue}");

            //// Unboxing
            //try
            //{
            //    int unboxedValue = (int)boxedValue;
            //    Console.WriteLine($"Unboxed value: {unboxedValue}");
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine($"Exception");
            //}
            #endregion

            #region 8th Question
            // Boxing copies value to heap; unboxing copies back to stack
            #endregion

            #region 9th Problem
            //static void SumAndMultiply(int a, int b, out int sum, out int product)
            //{
            //    sum = a + b;
            //    product = a * b;
            //}

            //int num1 = 5;
            //int num2 = 3;

            //SumAndMultiply(num1, num2, out int result1, out int result2);

            //Console.WriteLine($"Sum: {result1}");
            //Console.WriteLine($"Product: {result2}");
            #endregion

            #region 9th Question
            // Out parameters must be initialized inside the method because:
            // Ensures the caller always receives a value
            // Out parameters don't pass their initial values to the method
            #endregion

            #region 10th Problem
            //static void PrintString(string text, int times = 5)
            //{
            //    for (int i = 0; i < times; i++) Console.WriteLine(text);
            //}

            //// Using default value
            //Console.WriteLine("Using default value:");
            //PrintString("Hello");
            //Console.WriteLine();

            //// Using provided value
            //Console.WriteLine("Using provided value:");
            //PrintString("World", 3);
            //Console.WriteLine();

            //// Using named parameters
            //Console.WriteLine("Using named parameters:");
            //PrintString(times: 2, text: "Named");
            #endregion

            #region 10th Question
            // Because Compiler needs to match arguments to parameters from left to right
            #endregion

            #region 11th Problem
            //int[]? nullableArray = null;

            //Console.WriteLine($"Array length: {nullableArray?.Length}");
            //Console.WriteLine($"First element: {nullableArray?[0]}");

            //nullableArray = new int[] { 10, 20, 30 };

            //Console.WriteLine($"Array length: {nullableArray?.Length}");
            //Console.WriteLine($"First element: {nullableArray?[0]}");
            #endregion

            #region 11th Question
            // Returns null immediately if the object is null without attempting to access members
            #endregion

            #region 12th Problem
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();

            //int dayNumber = day?.ToLower() switch
            //{
            //    "saturday" => 1,
            //    "sunday" => 2,
            //    "monday" => 3,
            //    "tuesday" => 4,
            //    "wednesday" => 5,
            //    "thursday" => 6,
            //    "friday" => 7,
            //    _ => 0
            //};

            //if (dayNumber == 0) Console.WriteLine("Invalid day entered.");
            //else Console.WriteLine($"{day} = {dayNumber}");
            #endregion

            #region 12th Question
            // Need to map input values to corresponding outputs
            #endregion

            #region 13th Problem
            //static int SumArray(params int[] numbers)
            //{
            //    int sum = 0;
            //    foreach (int number in numbers) sum += number;
            //    return sum;
            //}

            //int result1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine($"Sum of individual values: {result1}");

            //int[] numbers = { 10, 20, 30, 40 };
            //int result2 = SumArray(numbers);
            //Console.WriteLine($"Sum of array: {result2}");

            //int result3 = SumArray();
            //Console.WriteLine($"Sum of no values: {result3}");
            #endregion

            #region 13th Question
            // A method can have only one params parameter
            #endregion

            // ---------------------------------------------------------------------- \\

            #region 1st Program
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Positive Number: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out num) || num <= 0);

            //for (int i = 1; i <= num; i++) Console.WriteLine(i); 
            #endregion

            #region 2nd Program
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Positive Number: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out num) || num <= 0);

            //for (int i = 1; i <= 12; i++) Console.WriteLine(i * num); 
            #endregion

            #region 3rd Program
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Positive Number: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out num) || num <= 0);

            //for (int i = 2; i <= num; i += 2) Console.WriteLine(i); 
            #endregion

            #region 4th Program
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int res = 1;


            //for (int i = 1; i <= num2; i++) res *= num1;
            //Console.WriteLine(res); 
            #endregion

            #region 5th Program
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
            #endregion

            #region 6th Program
            //int num = int.Parse(Console.ReadLine());

            //int reversed = 0;
            //int temp = num;

            //while (temp > 0)
            //{
            //    reversed = reversed * 10 + temp % 10;
            //    temp = temp / 10;
            //}
            //Console.WriteLine(reversed); 
            #endregion

            #region 7th Program
            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the array elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;
            //int element = -1;
            //int firstIndex = -1, lastIndex = -1;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                element = arr[i];
            //                firstIndex = i;
            //                lastIndex = j;
            //            }
            //        }
            //    }
            //}

            //if (maxDistance > 0)
            //{
            //    Console.WriteLine($"Longest distance: {maxDistance}");
            //    Console.WriteLine($"Element: {element}");
            //    Console.WriteLine($"Between positions {firstIndex} and {lastIndex}");
            //}
            //else Console.WriteLine("No matching elements found"); 
            #endregion

            #region 8th Program
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words)); 
            #endregion
        }
    }
}
