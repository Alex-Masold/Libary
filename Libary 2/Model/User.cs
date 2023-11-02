using Libary_2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Lidary_2.Model
{
    public class User : PropPropertyChanged
    {
        private static short _uniqueId = 0;
        private int id = _uniqueId;
        private string name;
        private string family;
        
        private ObservableCollection<Example> examples;


        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
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
        public string Family
        {
            get { return family; }
            set
            {
                family = value;
                OnPropertyChanged("Family");
            }
        }
        public int Count
        {
            get { return examples?.Count ?? 0; }
        }
        public ObservableCollection<Example> Examples
        {
            get { return examples; }
            set
            {
                examples = value;
                OnPropertyChanged("Examples");
            }
        }
    
        public User()
        {
            Examples = new();
        }
        
        public void BorrowBook(Book book)
        { 
            if (book.Count > 0)
            {
                this.Examples.Add(book.Examples.First());
                this.Examples.Last().NowUser = this.Name;
                this.Examples.Last().Time = DateTime.Now.ToString("t");
                book.Examples.Remove(book.Examples.First());
            }
            else
            {
                MessageBox.Show("книга кончилась, или отсутстувует");
            }
        }
        public void ReturnBook(Book book)
        {
            if (this.Count > 0)
            {
                if (book != null)
                {
                    book.Examples.Add(this.Examples.First());
                    book.Examples.Last().NowUser = null;
                    book.Examples.Last().Time = null;
                    this.Examples.Remove(this.Examples.First());
                }
                else
                {
                    MessageBox.Show("Выберете выданную книгу, если выданных книг, то выдайте");
                }
            }
        }
    }
    
}
