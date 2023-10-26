using System;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using Libary_2.Model;
using Lidary_2.Model;

namespace Libary_2.ViewModel
{

    public class ApplicationViewModel : PropPropertyChanged
    {
        private User selectedUser;
        private Book selectedBook;
        private string searchUserText;
        private string searchBookText;

        private ObservableCollection<User> filteredUsers;
        private ObservableCollection<Book> filteredBooks;

        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Book> Books { get; set; }
        public ObservableCollection<Example> Journal { get; set; }

        public ObservableCollection<User> FilteredUsers
        {
            get { return filteredUsers; }
            set
            {
                filteredUsers = value;
                OnPropertyChanged(nameof(FilteredUsers));
            }
        }
        public ObservableCollection<Book> FilteredBooks
        {
            get { return filteredBooks; }
            set
            {
                filteredBooks = value;
                OnPropertyChanged(nameof(FilteredBooks));
            }
        }

        private RelayCommand addUserCommand;
        private RelayCommand deleteUserCommand;
        private RelayCommand addBookCommand;
        private RelayCommand deleteBookCommand;
        private RelayCommand addExampleCommand;
        private RelayCommand extraditeBookCommand;
        private RelayCommand returnBookCommand;


        public RelayCommand AddUserCommand
        {
            get
            {
                return addUserCommand ??
                    (addUserCommand = new RelayCommand(obj =>
                    {
                        User user = new User();
                        Users.Add(user);
                        SelectedUser = user;
                    }));
            }
        }
        public RelayCommand DeleteUserCommand
        {
            get
            {
                return deleteUserCommand ??
                    (deleteUserCommand = new RelayCommand(obj =>
                    {
                        User user = SelectedUser;
                        Users.Remove(user);
                        SelectedUser = Users.LastOrDefault();
                    }));
            }
        }
        public RelayCommand AddBookCommand
        {
            get
            {
                return addBookCommand ??
                    (addBookCommand = new RelayCommand(obj =>
                    {
                        Book book = new Book();
                        Books.Add(book);
                        SelectedBook = book;
                    }));
            }
        }
        public RelayCommand DeleteBookCommand
        {
            get
            {
                return deleteBookCommand ??
                    (deleteBookCommand = new RelayCommand(obj =>
                    {
                        Book book = SelectedBook;
                        Books.Remove(book);
                        SelectedBook = Books.Last();
                    }));
            }
        }
        public RelayCommand AddExampleCommand
        {
            get
            {
                return addExampleCommand ??
                    (addExampleCommand = new RelayCommand(obj =>
                    {
                        if (SelectedBook != null)
                        {
                            Book book = SelectedBook;
                            Example example = new Example(book);
                            book.Examples.Add(example);
                        }
                    }));
            }
        }
        public RelayCommand ExtraditeBookCommand
        {
            get
            {
                return extraditeBookCommand ??
                    (extraditeBookCommand = new RelayCommand(obj =>
                    {
                        if (SelectedBook != null && SelectedUser != null)
                        {
                            Book book = SelectedBook;
                            User user = SelectedUser;
                            user.BorrowBook(book);
                            Journal.Add(user.Examples.Last());
                        }
                    }));
            }
        }
        public RelayCommand ReturnBookCommand
        {
            get
            {
                return returnBookCommand ??
                    (returnBookCommand = new RelayCommand(obj =>
                    {
                        if (SelectedBook != null && SelectedUser != null)
                        {
                            Book book = SelectedBook;
                            User user = SelectedUser;
                            user.ReturnBook(book);
                        }
                    }));
            }
        }

        public User SelectedUser
            {
                get { return selectedUser; }
                set
                {
                    selectedUser = value;
                    OnPropertyChanged("SelectedUser");
                }
            }
        public Book SelectedBook
            {
                get { return selectedBook; }
                set
                {
                    selectedBook = value;
                    OnPropertyChanged("SelectedBook");
                }
            }
        public string SearchUserText
        {
            get { return searchUserText; }
            set
            {
                searchUserText = value;
                OnPropertyChanged(nameof(searchUserText));
                SearchUser();
            }
        }
        public string SearchBookText
        {
            get { return searchBookText; }
            set
            {
                searchBookText = value;
                OnPropertyChanged(nameof(searchBookText));
                SearchBook();
            }
        }

        public ApplicationViewModel()
        {
            Users = new ObservableCollection<User>(DataContext.DataBase.Users);

            Books = new ObservableCollection<Book>(DataContext.DataBase.Books);

            Journal = new ObservableCollection<Example>();

            FilteredUsers = Users;
            FilteredBooks = Books;

            SelectedBook = Books.First();
            SelectedUser = Users.First();
        }
        private void SearchUser()
        {
            if (string.IsNullOrEmpty(SearchUserText))
            {
                FilteredUsers = Users;
            }
            else
            {
                FilteredUsers = new ObservableCollection<User>(
                    Users.Where
                    (
                        user => 
                        user.Name.Contains(SearchUserText, StringComparison.OrdinalIgnoreCase) ||
                        user.Family.Contains(SearchUserText, StringComparison.OrdinalIgnoreCase))
                    );
            }
        }
        private void SearchBook()
        {
            if (string.IsNullOrEmpty(SearchBookText))
            {
                FilteredBooks = Books;
            }
            else
            {
                FilteredBooks = new ObservableCollection<Book>(
                    Books.Where
                    (
                        book =>
                        book.Name.Contains(SearchBookText, StringComparison.OrdinalIgnoreCase) ||
                        book.Author.Contains(SearchBookText, StringComparison.OrdinalIgnoreCase))
                    );
            }
        }
    }
}
