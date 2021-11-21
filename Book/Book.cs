using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    /// <summary>
    /// Info about book.
    /// </summary>
    public class Book : IComparable
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public static int Edition { get; set; }

        public int IncreaseEditionNumber()
        {
            return ++Edition;
        }
        public int CompareTo(object? o) 
        {
            Book? book = o as Book;
            if (book==null)
                throw new Exception("Невозможно сравнить объекты");
            if (this.Author == book.Author && this.Title == book.Title)
                return 0;
            else if (this.Author == book.Author && this.Title != book.Title)
                return 1;
            else return -1;
        }
        public string BookComparison(object? o)
        {
            if (this.CompareTo(o)==0)
            { return "Это одинаковые произведения"; }
            else if (this.CompareTo(o) > 0) 
            { return "Это два разных произведения одного автора"; }
            else 
            { return "Это два разных произведения разных авторов";}
        }
        public override string ToString()
        {
          return $" {Edition}, {Author}, {Title}";
        }
    }
}

