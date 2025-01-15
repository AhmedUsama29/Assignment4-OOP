using Assignment4_OOP.Association.Composition;

namespace Assignment4_OOP
{
    internal class Program
    {

        #region Polymorphism-overloading
        //static int Sum02Numbers(int a, int b)
        //{
        //    return a + b;
        //}
        //static int Sum03Numbers(int a, int b,int c)
        //{
        //    return a + b + c;
        //}

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Inheritance and realationships between classes
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

            //Car car = new Car(1,2,3,4,5,"Toyota", 2020, 200);

            //Console.WriteLine(car);

            //Product P = new Product() { Name = "Coffee"}; 
            #endregion

            #region Polymorphosim--overloading

            #region Method Overloading
            ////int result = Sum02Numbers(1, 2);
            //int result = Sum(1, 2);
            //Console.WriteLine(result);

            //result = Sum(1, 2, 6);
            //Console.WriteLine(result);

            //result = Sum(1, 2, 2, 8);
            //Console.WriteLine(result);
            #endregion

            #region Operator Overloading

            //Complex c1 = new Complex();
            //c1.Real = 5;
            //c1.Imaginary = 3;
            //Console.WriteLine($"Complex 1 ===> {c1}");
            //Complex c2 = new Complex();
            //c2.Real = 2;
            //c2.Imaginary = 4;
            //Console.WriteLine($"Complex 2 ===> {c2}");

            //Complex c3 = c1 + c2;
            //Console.WriteLine($"Complex 3 ===> {c3}");

            //Complex c4 = c1 + 5;

            //Console.WriteLine($"Complex 4 ===> {c4}");

            //Complex c5 = 5 + c2;

            //Console.WriteLine($"Complex 5 ===> {c5}");

            //Console.WriteLine("-------------------unary------------------");
            //#region Unary operators

            //Complex c6 = c5++;

            //Console.WriteLine($"Complex 6 ===> {c6}");

            //Complex c7 = ++c6;

            //Console.WriteLine($"Complex 7 ===> {c7}");


            //Console.WriteLine("----------<&>-------------");

            //if (c1 > c2)
            //{
            //    Console.WriteLine("c1 > c2");
            //}
            //else
            //{
            //    Console.WriteLine("c1 < c2");
            //}

            #endregion

            #endregion

        }
    }
}
