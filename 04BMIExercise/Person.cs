using System;

class Person 
{
    // Attributes
    public double weight, height;

    // Methods
    public double BMI()
    {
        return weight / (height * height);
    }

    public string situation(double BMI)
    {
        string s = "";
        if (BMI >= 40)
            s = "Obesity III";

        if (BMI < 40)
            s = "Obesity II";

        if (BMI < 35)
            s = "Obesity I";

        if (BMI < 30)
            s = "Overweight";

        if (BMI < 25)
            s = "Normal Weight";

        if (BMI < 18.5)
            s = "Underweight";

        return s;
    }

    public void message()
    {
        // Get BMI
        double getBMI = BMI();

        // Get situation
        string getSituation = situation(getBMI);

        // Message
        Console.WriteLine("BMI: "+BMI());
        Console.WriteLine(getSituation);
    }
}
