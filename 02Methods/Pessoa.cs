using  System;  // Grants acess to Console.WriteLine()

class Pessoa  // --class-- needs to have the same name of the file!!!

    // Methods can have the same name, BUT they must have different parameters
{
    // Method 01
    public void present()
    {
        Console.WriteLine("Hello!!");
    }

    // Method 02
    public void present(string name)
    {
        Console.WriteLine("Hello " +name);
    }

    // Method 03
    public void present(string name, int age)
    {
        Console.WriteLine("Hello " +name+ ", You are " +age+ " years old");
    }

}