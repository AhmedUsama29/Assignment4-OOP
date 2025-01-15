namespace Assignment4_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*////////////////////////////////////////////////////////////////////
            Console.WriteLine("============Parent============");
            Parent parent = new Parent(1, 2);

            parent.X = 10;
            parent.Y = 20;

            Console.WriteLine(parent);
            Console.WriteLine(parent.Product());

            Console.WriteLine("============Child============");

            Child child = new Child(1, 2, 5);

            Console.WriteLine(child);
            Console.WriteLine(child.Product());

            //Animal = Parent
            //Dog = Child
            //Cat = Child
            /////////////////////////////////////////////////////////////////////////*/
            
            Car car = new Car(1,2,3,4,5,"Toyota", 2020, 200);

            Console.WriteLine(car);
        }
    }
}
