using System;
using System.Collections.Generic;
using System.Windows;

namespace Lidary.Model
{
    class User
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Family { get; set; }
        public List<Book> Books { get; set; }

        public User(int id, string? name, string? fаmily)
        {
            this.Id = id;
            this.Name = name;
            this.Family = fаmily;
            this.Books = new List<Book>();
        }

        
        public void BorrowBook(Book book, User user)
        {
            if (book.Count > 0)
            {
                var addedBook = (Book)book.Clone();
                addedBook.NowUser = user.Name;
                addedBook.Time = DateTime.Now.ToString("t");
                Books.Add(addedBook);
                book.Count--;
                
            }
            else
            {
                MessageBox.Show("книга кончилась");
            }
        }

        public void ReturnBook(Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
                book.Count++;
                book.Time = "";
            }
            else
            {
                MessageBox.Show("книга возвращена");
            }
        }
    }
}
