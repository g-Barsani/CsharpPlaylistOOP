using System;
namespace _11Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Intern
            Tax objectI = new Intern();  // 2 Different classes to create an object
            objectI.foodVoucher(1000);
            objectI.transportVoucher(1000);
            Console.WriteLine("---------------------------------------------------");

            // Instantiate Manager
            Tax objectM = new Manager();
            objectM.foodVoucher(5000);
            objectM.transportVoucher(5000);
            Console.WriteLine("---------------------------------------------------");

            // Instantiate Attendant
            Tax objectA = new Attendant();
            objectA.foodVoucher(2000);
            objectA.transportVoucher(200);
        }
    }
}