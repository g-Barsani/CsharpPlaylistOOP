using System;

class Student
{
    // Attributes
    private double grade1, grade2;

    // Avarage
    private double avarage()
    {
        return (grade1 + grade2) / 2;
    }

    // Message
    public void message()
    {
        Console.WriteLine("Insert grade 1: ");
        grade1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insert grade 2: ");
        grade2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The avarage is: " +avarage());
    }
}