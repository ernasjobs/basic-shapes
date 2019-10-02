using System;

namespace basic_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1=new Rectangle(34,25);
            Rectangle r2=new Rectangle(10,5);
            Rectangle r3=new Rectangle(15,30);

            Console.WriteLine("The are of first rectangle is: {0}",r1.GetArea());
            Console.WriteLine("The are of second rectangle is: {0}",r2.GetArea());
            Console.WriteLine("The are of third rectangle is: {0}",r3.GetArea());

            Console.ReadKey(true);
        }
    }
}
