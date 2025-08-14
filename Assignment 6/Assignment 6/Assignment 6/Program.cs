using System;

namespace Assignment_6
{
    #region Problem 1
    //public struct Point {
    //    public int x;
    //    public int y;

    //    // Defualt Constructor isn't allowed in our current version

    //    // Parameterized Constructor
    //    public Point(int newX, int newY)
    //    {
    //        x = newX;
    //        y = newY;
    //    }

    //    public override string ToString()
    //    {
    //        return $"X: {x} | Y: {y}";
    //    }
    //} 
    #endregion

    #region Problem 2
    //public class TypeA
    //{
    //    private int F { get; set;  }
    //    internal int G { get; set; }
    //    public int H { get; set; }

    //    public void DisplayValues()
    //    {
    //        Console.WriteLine($"F: {F}");
    //        Console.WriteLine($"G: {G}");
    //        Console.WriteLine($"H: {H}");
    //    }
    //} 
    #endregion

    #region Problem 3
    //struct Employee
    //{
    //    private int empId;
    //    private string name;
    //    private decimal salary;

    //    public Employee(int id, string employeeName, decimal employeeSalary)
    //    {
    //        empId = id;
    //        name = employeeName;
    //        salary = employeeSalary;
    //    }

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }

    //    public int EmpId
    //    {
    //        get { return empId; }
    //        set { if (value > 0) empId = value; }
    //    }

    //    public decimal Salary
    //    {
    //        get { return salary; }
    //        set { if (value >= 0) salary = value; }
    //    }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"ID: {empId}, Name: {name}, Salary: {salary:C}");
    //    }
    //} 
    #endregion

    #region Problem 4
    //struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public void DisplayPoint()
    //    {
    //        Console.WriteLine($"Point: ({X}, {Y})");
    //    }
    //}
    #endregion

    #region Problem 5
    //struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Point coordinates: ({X}, {Y})";
    //    }
    //} 
    #endregion

    #region Problem 6 (Bonus)
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Employee
    {
        public int Id;
        public string Name;

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    } 
    #endregion

    internal class Program
    {
        #region Problem 6 (Bonus) - Methods
        //// Method to modify struct (value type)
        //static void ModifyPoint(Point p)
        //{
        //    p.X = 100;
        //    p.Y = 100;
        //}

        //// Method to modify class (reference type)
        //static void ModifyEmployee(Employee emp)
        //{
        //    emp.Id = 999;
        //    emp.Name = "Modified";
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Testing Problem 1
            //Point newPoint = new Point(5, 8);
            //Console.WriteLine(newPoint); 
            #endregion

            #region Question 1
            // Because Structs are Stack Allowed, and inheritance would require heap allocation
            #endregion

            #region Testing Problem 2
            //TypeA a = new TypeA();
            //a.G = 5;
            //a.H = 6;
            //// Console.WriteLine(obj.F);  // Error: Cannot access private field
            //// Console.WriteLine($"F (private): {a.F}");       // in Accessable BCZ it's Private
            //Console.WriteLine($"G (internal): {a.G}");      // Accessible - same Project
            //Console.WriteLine($"H (public): {a.H}");        // Accessible - public 
            #endregion

            #region Question 2
            // By 6 Types Of Access Modifiers
            #endregion

            #region Testing Problem 3
            //Employee emp = new Employee(101, "Amr", 50000m);

            //emp.DisplayInfo();

            //emp.Name = "Ahmed";
            //emp.EmpId = 102;
            //emp.Salary = 55000m;

            //emp.DisplayInfo(); 
            #endregion

            #region Question 3
            //Because it Prevents direct access to internal data, ensuring data integrity 
            #endregion

            #region Testing Problem 4
            //// Using default constructor
            //Point point1 = new Point();
            //point1.DisplayPoint();

            //// Using constructor with one parameter
            //Point point2 = new Point(5);
            //point2.DisplayPoint();

            //// Using constructor with two parameters
            //Point point3 = new Point(10, 15);
            //point3.DisplayPoint();
            #endregion

            #region Question 4
            // Constructors in structs are special methods that:Cannot be parameterless, Must initialize all fields
            #endregion

            #region Testing Problem 5
            //Point point1 = new Point();
            //Point point2 = new Point(5);
            //Point point3 = new Point(10, 15);
            //Point point4 = new Point(-3, 7);

            //Console.WriteLine(point1);
            //Console.WriteLine(point2);
            //Console.WriteLine(point3);
            //Console.WriteLine(point4);
            #endregion

            #region Question 5
            // Overriding methods like ToString() improves code readability by:  Makes debugging simpler with clear object state information
            #endregion

            #region Testing Problem 6 (Bonus) 
            //// Struct (value type)
            //Point point = new Point(5, 10);
            //Console.WriteLine($"Before - Point: {point}");
            //ModifyPoint(point);
            //Console.WriteLine($"After - Point: {point}");
            //Console.WriteLine();

            //// Class (reference type)
            //Employee emp = new Employee(101, "John");
            //Console.WriteLine($"Before - Employee: {emp}");
            //ModifyEmployee(emp);
            //Console.WriteLine($"After - Employee: {emp}");
            #endregion

            #region Question 6 (Bonus)
            // Structs (Value types): Allocated on the stack, copied by value
            // Classes(Reference types): Allocated on the heap, passed by reference
            #endregion

        }
    }
}
