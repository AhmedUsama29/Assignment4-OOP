namespace Assignment4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Parent parent = new Parent(1, 2);

            parent.X = 10;
            parent.Y = 20;

            Console.WriteLine(parent);
            Console.WriteLine(parent.Product());

        }
    }
}
