using System;

class Calculation : IDefault
{
    public void sum(int n1, int n2)
    {
        Console.WriteLine("The sum is: " + (n1 + n2));
    }

    public void subtraction(int n1, int n2)
    {
        Console.WriteLine("The subtraction is: " + (n1 - n2));
    }
}