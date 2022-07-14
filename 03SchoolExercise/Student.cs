using System;

class Student
{
    // Attributes
    public string name = string.Empty;
    public double grade1, grade2;

    // Avarage
    public double avarage()
    {
        return (grade1 + grade2) / 2;
    }

    // Situation
    public string situation(double avarage)
    {
        return avarage >= 7 ? "Passed" : "Failed";
    }
    // Message
    public void message()
    {
        // Get avarage 
        double getAvarage = avarage();

        // Get situation
        string getSituation = situation(getAvarage);

        // Message
        Console.WriteLine(name+ " has " +getSituation+ " with avarage of " +getAvarage);
    }
}