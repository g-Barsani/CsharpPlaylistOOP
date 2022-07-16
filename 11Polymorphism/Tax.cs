using System;
class Tax
{
    // Methods
    public virtual void foodVoucher(double salary)  
    {
        Console.WriteLine("Food voucher default discount $" +(salary * 0.1));
    }

    public void transportVoucher(double salary)
    {
        Console.WriteLine("Transport voucher default discount $" +(salary * 0.06));
    }
}
