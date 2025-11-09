using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== C# Generics Demo ===\n");

        // Демонстрация Swap метода
        DemoClass1.RunDemo();

        // Демонстрация LinkedList
        DemoClass2.RunDemo();

        // Демонстрация IPrintable интерфейса
        DemoClass3.RunDemo();

        Console.WriteLine("All demos completed!");
        Console.ReadLine();
    }
}