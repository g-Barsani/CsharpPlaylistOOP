using System;

class Person
{
    // Attributes
    protected string? name;
    protected int age;

    // Method 
    protected void messagePerson()
    {
        Console.WriteLine("Name: " +name);
        Console.WriteLine("Age: " +age);
    }
}