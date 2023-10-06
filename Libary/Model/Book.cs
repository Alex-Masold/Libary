using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidary.Model
{
    public class Book
    {
        public short Act { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public string age { get; set; }
        public int Count { get; set; }
        public string Time { get; set; }
        public string NowUser {get; set; }

        public Book(short act, string name, string author, int year, int month, int day, int count)
        { 
            Name = name;
            Author = author;
            Act = act;
            age = new DateTime(year, month, day).ToString("dd.MM.yyyy");
            Count = count;
        }
    }
}
