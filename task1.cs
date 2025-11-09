using System;

public class SwapExample
{
    public static void Swap<T>(ref T x, ref T y) where T : struct
    {
        T temp = x;
        x = y;
        y = temp;
    }
}

public class DemoClass1
{
    public static void RunDemo()
    {
        Console.WriteLine("=== 1. Swap Method Demo ===");

        int a = 10, b = 20;
        Console.WriteLine($"Before swap: a = {a}, b = {b}");
        SwapExample.Swap(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}, b = {b}");

        double x = 3.14, y = 2.71;
        Console.WriteLine($"Before swap: x = {x}, y = {y}");
        SwapExample.Swap(ref x, ref y);
        Console.WriteLine($"After swap: x = {x}, y = {y}");

        bool flag1 = true, flag2 = false;
        Console.WriteLine($"Before swap: flag1 = {flag1}, flag2 = {flag2}");
        SwapExample.Swap(ref flag1, ref flag2);
        Console.WriteLine($"After swap: flag1 = {flag1}, flag2 = {flag2}");

        Console.WriteLine();
    }
}