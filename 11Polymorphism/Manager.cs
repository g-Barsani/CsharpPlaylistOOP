using System;
class Manager : Tax
{
    // Method
    public override void foodVoucher(double salary)
    {
        Console.WriteLine("Food voucher manager discount $" +(salary * 0.15));
    }
}
