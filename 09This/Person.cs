using System;

class Person
{

    // Attribute
    private string name = "Jade";

    // Constructor
    public Person(string name)
    {
        Console.WriteLine(name);  // Refers to the parameter
        Console.WriteLine(this.name);  // Refers to the attribute (line 7)
    }
}