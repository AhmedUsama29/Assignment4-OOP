namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA typeA = new TypeA(1,2,3,4,5);
            typeA.A = 10;
            //typeA.B = 20; //Error
            //typeA.C = 30; //Error
            //typeA.D = 40; //Error
            typeA.E = 50;


            TypeB typeB = new TypeB(1,2,3,4,5,6,7);
            Console.WriteLine(typeB);
            typeB.A = 10;
            //typeB.B = 20; //as it is private in the parent
            //typeB.C = 30; //protected //privare inside typeB only
            //typeB.D = 40; //private protected // privare inside type
            //B only
            typeB.E = 50;
            typeB.F = 60;
            typeB.G = 70;


        }
    }
}
