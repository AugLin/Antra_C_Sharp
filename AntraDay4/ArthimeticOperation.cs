﻿namespace AntraDay4;

public abstract class ArthimeticOperation
{
    public static void Add(int a, int b)
    {
        Console.WriteLine($"Sum of a and b is {a + b}");
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}