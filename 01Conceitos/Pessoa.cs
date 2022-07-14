using System;

class Pessoa // class -> blueprint, molde
{
    // Attributes
    public string name;  // -- public -- All cs files have acess to this method or attribute
    public int age;

    // Methods (functions)
    public void message()
    {
        Console.WriteLine("Hello " + name + ", you are " + age + " years old");
    }
    //Valeu Gabaiel
}