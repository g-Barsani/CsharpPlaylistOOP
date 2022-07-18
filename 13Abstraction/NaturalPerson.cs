using System;
class NaturalPerson : Default
{
    // Mandatory Method
    public override void taxLoan(double value)
    {
        Console.WriteLine("Loan tax for Natural Person $ " + (value * 0.1));
    }
}