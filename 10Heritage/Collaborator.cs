class Collaborator : Person  // You should use ":" in order to use heritage
{
    // Attributes
    private double salary;

    // Constructor
    public Collaborator(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;

        messagePerson();
        messageCollaborator();
    }

    // Method
    private void messageCollaborator()
    {
        Console.WriteLine("Salary: " +salary);
    }
}