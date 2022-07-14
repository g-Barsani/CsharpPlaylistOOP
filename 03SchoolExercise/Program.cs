using System;

namespace _03SchoolExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // The process of creating an object from a class is called instantiation 
            // An object is an instance of a class

            // Instatiate Student Class's object
            Student s = new Student();
            s.name = "Gabriel";
            s.grade1 = 8;
            s.grade2 = 10;
            s.message();
        }
    }
}