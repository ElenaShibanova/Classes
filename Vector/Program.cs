using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            v1.Append(-5);
            v1.Append(4.8);
            v1.Append(1.2E5);
            Vector v2 = new Vector(3);
            v2.SetElementAt(0, -1);
            v2.SetElementAt(1, 3.6);
            v2.SetElementAt(2, -8.3);

            v1.print(0);
            v1.print();
            v2.print();
            v1.Add(v2).print();
            v2.Subtract(v1).print();
            v1.Multiply(7.1).print();
            v2.Divide(-3.6).print();
            Console.ReadKey();
        }
    }
}
