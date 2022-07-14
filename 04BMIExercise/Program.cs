using System;

namespace _04BMIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.weight = 120.0;
            p.height = 2.0;
            p.message();
        }
    }
}