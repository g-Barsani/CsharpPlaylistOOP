using System;
class Attendant : Tax
{
    public override void foodVoucher(double salary)
    {
        Console.WriteLine("Food voucher attendant discount $" +(salary * 0.12));
    }
}
