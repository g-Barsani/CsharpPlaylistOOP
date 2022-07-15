using System;

namespace _04BMIExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.weight = 190.0;
            p.height = 2.5;
            p.message();
        }
    }
}