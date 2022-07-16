using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate Intern
        Tax objectI = new Intern();  // 2 Different classes to create an object
        objectE.foodVoucher(1000);
        objectE.transportVoucher(1000);
        Console.WritenLine("---------------------------------------------------");

        // Instantiate Manager
        Tax objectM = new Manager();
        objectM.foodVoucher(5000);
        objectM.transportVoucher(5000);
        Console.WritenLine("---------------------------------------------------");

        // Instantiate Attendant
        Tax objectA = new Attendant();
        objectA.foodVoucher(2000);
        objectA.transportVoucher(200);
    }
}