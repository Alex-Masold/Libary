using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace Libary_2.Model
{
    public class Example : PropPropertyChanged
    {
        private int arc;
        private string name;
        private string author;
        private string time;
        private string nowUser;

        public int Arc
        {
            get { return arc; }
            set
            {
                arc = value;
                OnPropertyChanged("Arc");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }
        public string Time
        {
            get { return time ; }
            set
            {
                time = value;
                OnPropertyChanged(nameof(Time));
            }
        }
        public string NowUser
        {
            get { return nowUser; }
            set
            {
                nowUser = value;
                OnPropertyChanged("NowUser");
            }
        }
        public Example(Book selectedBook)
        {     
            Arc = selectedBook.Id * 100;
            Name = selectedBook.Name;
            Author = selectedBook.Author;
        }
    }
}
