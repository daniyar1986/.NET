using System;

class Test
{
    public static void Main()
    {

        Console.WriteLine(FeetToInch(30));
        Console.WriteLine(FeetToInch(100));
    }

    static int FeetToInch(int feet)
    {
        return feet * 12;
    }

    int Foo(int x) => x * 2;

}