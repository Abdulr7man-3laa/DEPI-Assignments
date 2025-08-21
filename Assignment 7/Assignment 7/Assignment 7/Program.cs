using System;
using System.Xml.Linq;

namespace Assignment_7
{
    //class Car
    //{
    //    public int Id { get; set; }
    //    public string Brand { get; set; }
    //    public decimal Price { get; set; }

    //    // Default constructor
    //    public Car()
    //    {
    //        Id = 0;
    //        Brand = "Unknown";
    //        Price = 0.0m;
    //    }

    //    // Constructor with one parameter (Id)
    //    public Car(int id)
    //    {
    //        Id = id;
    //        Brand = "Unknown";
    //        Price = 0.0m;
    //    }

    //    // Constructor with two parameters (Id, Brand)
    //    public Car(int id, string brand)
    //    {
    //        Id = id;
    //        Brand = brand;
    //        Price = 0.0m;
    //    }

    //    // Constructor with all three parameters
    //    public Car(int id, string brand, decimal price)
    //    {
    //        Id = id;
    //        Brand = brand;
    //        Price = price;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Car ID: {Id}, Brand: {Brand}, Price: {Price:C}";
    //    }
    //}

    //class Calculator
    //{
    //    public int Sum(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public int Sum(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }

    //    public double Sum(double a, double b)
    //    {
    //        return a + b;
    //    }
    //}

    //class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //        Console.WriteLine($"Parent constructor called: X={X}, Y={Y}");
    //    }
    //}

    //class Child : Parent
    //{
    //    public int Z { get; set; }

    //    public Child(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //        Console.WriteLine($"Child constructor called: Z={Z}");
    //    }

    //    public void DisplayValues()
    //    {
    //        Console.WriteLine($"X={X}, Y={Y}, Z={Z}");
    //    }
    //}

    //class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public virtual int Product()
    //    {
    //        return X * Y;
    //    }
    //}

    //class ChildWithNew : Parent
    //{
    //    public int Z { get; set; }

    //    public ChildWithNew(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //    }

    //    // Using 'new' keyword - method hiding
    //    public new int Product()
    //    {
    //        return X * Y * Z;
    //    }
    //}

    //class ChildWithOverride : Parent
    //{
    //    public int Z { get; set; }

    //    public ChildWithOverride(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //    }

    //    // Using 'override' keyword - method overriding
    //    public override int Product()
    //    {
    //        return X * Y * Z;
    //    }
    //}

    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            //Car car1 = new Car();
            //Console.WriteLine($"Default constructor: {car1}");

            //Car car2 = new Car(101);
            //Console.WriteLine($"Constructor with Id: {car2}");

            //Car car3 = new Car(102, "Toyota");
            //Console.WriteLine($"Constructor with Id and Brand: {car3}");

            //Car car4 = new Car(103, "Honda", 25000m);
            //Console.WriteLine($"Constructor with all parameters: {car4}"); 
            #endregion

            #region Question 1
            // Because If you define any constructor, the compiler assumes you want full control over object initialization
            #endregion

            #region Problem 2
            //Calculator calc = new Calculator();

            //int result1 = calc.Sum(5, 10);
            //Console.WriteLine($"Sum of two integers (5, 10): {result1}");

            //int result2 = calc.Sum(5, 10, 15);
            //Console.WriteLine($"Sum of three integers (5, 10, 15): {result2}");

            //double result3 = calc.Sum(5.5, 10.3);
            //Console.WriteLine($"Sum of two doubles (5.5, 10.3): {result3}");
            #endregion

            #region Question 2
            // Uses the same method name for similar operations, making code intuitive
            #endregion

            #region Problem 3
            //Console.WriteLine("Creating Child instance:");
            //Child child = new Child(10, 20, 30);

            //Console.WriteLine("\nChild values:");
            //child.DisplayValues();
            #endregion

            #region Question 3
            // Avoids duplicating initialization logic from the base class
            #endregion

            #region Problem 4
            //// 'new' keyword behavior
            //Console.WriteLine("=== Using 'new' keyword ===");
            //ChildWithNew childNew = new ChildWithNew(2, 3, 4);
            //Parent parentRefNew = childNew;

            //Console.WriteLine($"childNew.Product(): {childNew.Product()}");
            //Console.WriteLine($"parentRefNew.Product(): {parentRefNew.Product()}");
            //Console.WriteLine();

            //// 'override' keyword behavior
            //Console.WriteLine("=== Using 'override' keyword ===");
            //ChildWithOverride childOverride = new ChildWithOverride(2, 3, 4);
            //Parent parentRefOverride = childOverride;

            //Console.WriteLine($"childOverride.Product(): {childOverride.Product()}");
            //Console.WriteLine($"parentRefOverride.Product(): {parentRefOverride.Product()}"); 
            #endregion

            #region Question 4
            // new keyword: Hides the parent method, creating a separate method. Parent reference calls parent method
            // override keyword: Replaces the parent method implementation.Parent reference calls overridden method
            #endregion

            #region Problem 5
            //Parent parent = new Parent(10, 20);
            //Child child = new Child(30, 40, 50);

            //// Direct printing
            //Console.WriteLine($"Parent: {parent}");
            //Console.WriteLine($"Child: {child}");
            //Console.WriteLine();

            //// Polymorphism demonstration
            //Parent[] objects = { parent, child, new Child(1, 2, 3) };

            //Console.WriteLine("Polymorphic behavior:");
            //foreach (Parent obj in objects)
            //{
            //    Console.WriteLine(obj);
            //}
            #endregion

            #region Question 5
            //  Provides human-readable representation instead of default type name
            #endregion




        }
    }
}
