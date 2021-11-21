using System;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet set1 = new MySet();
            set1.Add("Елене");
            set1.Add("нравятся");
            set1.Add("книги");
            string[] Maxim = { "Максиму","Максиму", "нравятся", "книги", "и", "фильмы" };
            MySet set2 = new MySet(Maxim);
            Console.WriteLine(set1[0]);
            Console.WriteLine(set1[0]);
            Console.WriteLine(set1.Union(set2));
            Console.WriteLine(set1 + set2);
            Console.WriteLine(set1.Intersection(set2));
            Console.WriteLine(set1 * set2);
            Console.WriteLine(set2.Difference(set1));
            Console.WriteLine(set2 - set1);
            Console.WriteLine(set1.SubSet(set1.Intersection(set2)));
            Console.WriteLine(set1);
            Console.WriteLine(set1);
            set1[0] = "фильмы";
            Console.WriteLine(set1);
            Console.WriteLine(set2);
        }
    }
}
