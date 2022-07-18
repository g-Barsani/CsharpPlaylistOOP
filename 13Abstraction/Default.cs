using System;

abstract class Default
{
    // Mandatory
    public abstract void taxLoan(double value);

    // Optional
    public void calculateSavingsACC(double value, double tax)
    {
        Console.WriteLine("Gains obtained by the savings account $ " +(value * tax));
    }
}