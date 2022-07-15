class Person
{

    // Attribute name
    private string? name;

    // Get & Set -> these methods are always public so other classes can have access
    public string Name  // The first letter is capitalized
    {
        get
        {
            return name = "";
        }
        set
        {
            name = value;
        }
        // You don't need to use both
    }
}

// The names get and set are self explanatory
// set: put, lay, or stand (something) in a specified place or position