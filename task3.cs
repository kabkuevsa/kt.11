using System;

// Простой не-generic интерфейс
public interface IPrintable
{
    void Print();
}

public class Student : IPrintable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void Print()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Grade: {Grade:F2}");
    }
}

public struct Vector : IPrintable
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Print()
    {
        Console.WriteLine($"Vector: ({X:F2}, {Y:F2}, {Z:F2})");
    }
}

public static class Printer
{
    public static void PrintItem(IPrintable item)
    {
        item.Print();
    }
}

public class DemoClass3
{
    public static void RunDemo()
    {
        Console.WriteLine("=== 3. IPrintable Interface Demo ===");

        Student student = new Student("John Doe", 20, 85.5);
        Vector vector = new Vector(1.5, 2.3, 3.7);

        Console.WriteLine("Using Printer.PrintItem():");
        Printer.PrintItem(student);
        Printer.PrintItem(vector);

        Console.WriteLine("Direct interface calls:");
        IPrintable printableStudent = student;
        IPrintable printableVector = vector;
        printableStudent.Print();
        printableVector.Print();

        Console.WriteLine();
    }
}