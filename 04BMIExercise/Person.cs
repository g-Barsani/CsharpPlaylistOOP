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
        if (BMI < 18.5)
            s = "Underweight";

        else if (BMI < 25)
            s = "Normal Weight";

        else if (BMI < 30)
            s = "Overweight";

        else if (BMI < 35)
            s = "Obesity I";

        else if (BMI >= 40)
            s = "Obesity III";

        else
            s = "Obesity II";

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
