using System;
public class MyMath
{
    static public int Cube(int x)
    {
        return x * x * x;
    }
    static public double Cube(double x)
    {
        return x * x * x;
    }
    static public int MinElement(int a, int b, int c)
    {
        int min = (a <= b && a <= c) ? a : (b <= a && b <= c) ? b : c;
        return min;
    }
    static public int MinElement(int a, int b, int c, int d)
    {
        int min = a;
        if (min > b) min = b;
        if (min > c) min = c;
        if (min > d) min = d;
        return min;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Cube of the number 7 = {MyMath.Cube(7)}\n" +
            $"And cube of number 4.55 = {MyMath.Cube(4.55):00.00}\n" +
            $"Min value of three numbers [77,10,100] = {MyMath.MinElement(77,10,100)}\n" +
            $"Min value of four numbers [1,2,3,4] = {MyMath.MinElement(1,2,3,4)}");
    }
}