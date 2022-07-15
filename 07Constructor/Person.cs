using System;

class Person
{
    // Constructor
    public Person()  // Constructor are always -- public --
    {
        Console.WriteLine("Constructor executed");
    }

    public Person(string name)
    {
        
        Console.WriteLine("Hello " +name);
    }
}