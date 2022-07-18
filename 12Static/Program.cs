namespace _12Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can access a method without instatiating an object
            Example.sum(3, 7);

            Console.WriteLine("Hello " + Example.name);
        }
    }
}
