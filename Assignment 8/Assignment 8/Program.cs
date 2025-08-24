using System;
using System.Reflection.Metadata;
using System.Text;

namespace Assignment_9
{
    internal class Program
    {
        static void Main()
        {
            #region Problem 1
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();
            //car.StartEngine();
            //car.StopEngine();
            //bike.StartEngine();
            //bike.StopEngine();
            #endregion

            #region Problem 2
            //Shape rectangle = new Rectangle(5, 3);
            //Shape circle = new Circle(4);
            //rectangle.Display();
            //circle.Display();
            #endregion

            #region Problem 3
            //Product[] products = { new Product(1, "A", 50), new Product(2, "B", 30), new Product(3, "C", 70) };
            //Array.Sort(products);
            //foreach (Product p in products)
            //    Console.WriteLine($"{p.Name}: {p.Price}");
            #endregion

            #region Problem 4
            //Student original = new Student(1, "John", 85);
            //Student shallowCopy = original;
            //Student deepCopy = new Student(original);
            //original.Name = "Jane";
            //Console.WriteLine($"Original: {original.Name}");
            //Console.WriteLine($"Shallow: {shallowCopy.Name}");
            //Console.WriteLine($"Deep: {deepCopy.Name}");
            #endregion

            #region Problem 5
            //Robot robot = new Robot();
            //((IWalkable)robot).Walk();
            //robot.Walk();
            #endregion

            #region Problem 6
            //Account acc = new Account("123", "Alice", 1000);
            //Console.WriteLine($"{acc.AccountHolder}: {acc.Balance}");
            #endregion

            #region Problem 7
            //ILogger logger = new ConsoleLogger();
            //logger.Log();
            #endregion

            #region Problem 8
            //Book book1 = new Book();
            //Book book2 = new Book("C# Programming");
            //Book book3 = new Book("Design Patterns", "Gang of Four");

            //Console.WriteLine($"{book1.Title} by {book1.Author}");
            //Console.WriteLine($"{book2.Title} by {book2.Author}");
            //Console.WriteLine($"{book3.Title} by {book3.Author}");
            #endregion

            // Question 1: Coding against interfaces provides loose coupling and easier testing / mocking.
            // Question 2: Abstract classes are preferred when you need to share common implementation along with contracts.
            // Question 3: IComparable provides a standard sorting contract that works with built-in sorting methods.
            // Question 4: Copy constructors create independent object copies to prevent unwanted shared references.
            // Question 5: Explicit interface implementation allows different behaviors for same method names from different sources.
            // Question 6: Structs use value semantics while classes use reference semantics for encapsulation.
            // Question 7: Default interface implementations allow adding new methods without breaking existing implementations.
            // Question 8: Constructor overloading provides multiple ways to initialize objects with different parameter combinations.

            #region Part 1
            PrintTenShapes(new SquareSeries());
            PrintTenShapes(new CircleSeries());
            #endregion

            #region Part 2
            Shape[] shapes = { new Shape("Square", 25), new Shape("Circle", 78.5), new Shape("Rectangle", 30) };
            Array.Sort(shapes);
            foreach (Shape s in shapes)
                Console.WriteLine($"{s.Name}: {s.Area}");
            #endregion

            #region Part 3
            GeometricShape triangle = new Triangle(5, 4);
            GeometricShape rectangle = new Rectangle(6, 3);
            Console.WriteLine($"Triangle - Area: {triangle.CalculateArea()}, Perimeter: {triangle.Perimeter}");
            Console.WriteLine($"Rectangle - Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.Perimeter}");
            #endregion

            #region Part 4
            int[] areas = { 30, 25, 78 };
            SelectionSort(areas);
            foreach (int area in areas)
                Console.WriteLine(area);
            #endregion

            #region Part 5
            ShapeFactory factory = new ShapeFactory();
            GeometricShape factoryRect = factory.CreateShape("Rectangle", 4, 5);
            GeometricShape factoryTriangle = factory.CreateShape("Triangle", 3, 6);
            Console.WriteLine($"Factory Rectangle Area: {factoryRect.CalculateArea()}");
            Console.WriteLine($"Factory Triangle Area: {factoryTriangle.CalculateArea()}");
            #endregion
        }
        static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.CurrentShapeArea);
                series.GetNextArea();
            }
            series.ResetSeries();
        }

        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                        minIndex = j;
                }
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }
    }

    #region Problem 1
    interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }

    class Car : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Car engine started");
        public void StopEngine() => Console.WriteLine("Car engine stopped");
    }

    class Bike : IVehicle
    {
        public void StartEngine() => Console.WriteLine("Bike engine started");
        public void StopEngine() => Console.WriteLine("Bike engine stopped");
    }
    #endregion

    #region Problem 2
    abstract class Shape
    {
        public abstract double GetArea();
        public void Display() => Console.WriteLine($"Area: {GetArea()}");
    }

    class Rectangle : Shape
    {
        private double width, height;
        public Rectangle(double w, double h) { width = w; height = h; }
        public override double GetArea() => width * height;
    }

    class Circle : Shape
    {
        private double radius;
        public Circle(double r) { radius = r; }
        public override double GetArea() => Math.PI * radius * radius;
    }
    #endregion

    #region Problem 3
    class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id; Name = name; Price = price;
        }

        public int CompareTo(Product other) => Price.CompareTo(other.Price);
    }
    #endregion

    #region Problem 4
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id; Name = name; Grade = grade;
        }

        public Student(Student other)
        {
            Id = other.Id; Name = other.Name; Grade = other.Grade;
        }
    }
    #endregion

    #region Problem 5
    interface IWalkable
    {
        void Walk();
    }

    class Robot : IWalkable
    {
        void IWalkable.Walk() => Console.WriteLine("Robot walking via interface");
        public void Walk() => Console.WriteLine("Robot walking via class method");
    }
    #endregion

    #region Problem 6
    struct Account
    {
        private string accountId;
        private string accountHolder;
        private decimal balance;

        public Account(string id, string holder, decimal bal)
        {
            accountId = id; accountHolder = holder; balance = bal;
        }

        public string AccountId => accountId;
        public string AccountHolder => accountHolder;
        public decimal Balance => balance;
    }
    #endregion

    #region Problem 7
    interface ILogger
    {
        void Log() => Console.WriteLine("Default log implementation");
    }

    class ConsoleLogger : ILogger
    {
        public void Log() => Console.WriteLine("Console logger implementation");
    }
    #endregion

    #region Problem 8
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }

        public Book(string title)
        {
            Title = title;
            Author = "Unknown";
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    #endregion

    #region Part 1
    interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    class SquareSeries : IShapeSeries
    {
        private int side = 1;
        public int CurrentShapeArea { get; set; }

        public SquareSeries() => CurrentShapeArea = side * side;

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 1;
            CurrentShapeArea = side * side;
        }
    }

    class CircleSeries : IShapeSeries
    {
        private int radius = 1;
        public int CurrentShapeArea { get; set; }

        public CircleSeries() => CurrentShapeArea = (int)(Math.PI * radius * radius);

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 1;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }
    }
    #endregion

    #region Part 2
    class Shape : IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape other) => Area.CompareTo(other.Area);
    }
    #endregion

    #region Part 3
    abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        protected GeometricShape(double dim1, double dim2)
        {
            Dimension1 = dim1;
            Dimension2 = dim2;
        }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }

    class Triangle : GeometricShape
    {
        public Triangle(double dim1, double dim2) : base(dim1, dim2) { }
        public override double CalculateArea() => 0.5 * Dimension1 * Dimension2;
        public override double Perimeter => Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
    }

    class Rectangle : GeometricShape
    {
        public Rectangle(double dim1, double dim2) : base(dim1, dim2) { }
        public override double CalculateArea() => Dimension1 * Dimension2;
        public override double Perimeter => 2 * (Dimension1 + Dimension2);
    }
    #endregion

    #region Part 5
    class ShapeFactory
    {
        public GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            return shapeType.ToLower() switch
            {
                "rectangle" => new Rectangle(dim1, dim2),
                "triangle" => new Triangle(dim1, dim2),
                _ => null
            };
        }
    }
    #endregion

}

