using System;

class LegalPerson : Default
{
    // Mandatory Method
    public override void taxLoan(double value)
    {
        Console.WriteLine("Loan tax for Legal Person $ " + (value * 0.2));
    }
}