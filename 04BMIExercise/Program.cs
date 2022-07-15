using System;

namespace _04BMIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.weight = 130.0;
            p.height = 1.5;
            p.message();
        }
    }
}