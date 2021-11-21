using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book warAndPeace = new Book { Author = "Lev Tolstoy", Title = "War and Peace" };
            warAndPeace.IncreaseEditionNumber();
            Console.WriteLine(warAndPeace);
            Book serlokHolmes = new Book { Author = "Conan Doyle", Title = "War and Peace" };
            serlokHolmes.IncreaseEditionNumber();
            Console.WriteLine(serlokHolmes);
            Book sunday = new Book { Author = "Lev Tolstoy", Title = "Sunday" };
            sunday.IncreaseEditionNumber();
            Console.WriteLine(sunday);
            Console.WriteLine(warAndPeace.BookComparison(serlokHolmes));
            Console.WriteLine(serlokHolmes.BookComparison(serlokHolmes));
            Console.WriteLine(sunday.BookComparison(warAndPeace));

        }
    }
}