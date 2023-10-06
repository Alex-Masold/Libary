﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Lidary.Model;


namespace Libary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Book> Books = new List<Book>();

        List<User> users = new List<User>()
            {
                new User(1, "Флопа", "Хлопавич"),
                new User(2, "А", "Ашович"),
                new User(3, "Б", "Бешович"),
                new User(4, "В", "Вевовочи"),
                new User(5, "Г", "Гегович"),
                new User(6, "Шлёпа", "Шлёпович")
                
            };

        List<Book> books = new List<Book>()
            {
                new Book(1, "Все о чмокололадках","Никита Честных", 2020, 1, 27, 5),
                new Book(2, "Все о дед инсайдах", "Андрей Науменко",  2023, 3, 10, 10),
                new Book(3, "Все о yipppe", "?Александр Сидоров?", 2022, 2, 1, 1)
            };


        public MainWindow()
        {
            InitializeComponent();

            UserList.ItemsSource = users;
            UserList.FontSize = 10;

            BookList.ItemsSource = books;
            BookList.FontSize = 10;


            BookSelector.ItemsSource = BookList.ItemsSource = books;
            UserSelector.ItemsSource = UserList.ItemsSource = users;

        }
        private void AddSelectedBook(object sender, RoutedEventArgs e)
        {
            AddBookUser();
        }

        private void AddBookUser()
        {
            User selectedUser = (User)UserSelector.SelectedItem;
            Book selectedBook = (Book)BookSelector.SelectedItem;
            if (selectedUser != null && selectedBook != null)
            {
                selectedUser.BorrowBook(selectedBook, selectedUser);
                UpdateBookUserList();
                UpdateBookList();
            }
            else
            {
                MessageBox.Show("Выберите пользователя и книгу");
            }
        }
        private void UpdateBookList()
        {
            BookList.Items.Refresh();
        }
        private void UpdateBookUserList()
        {
            List<Book> allBooks = new List<Book>();
            foreach (var user in (UserList.ItemsSource as List<User>)!)
            {
                allBooks.AddRange(user.Books);
            }
            BookUserList.ItemsSource = allBooks;
        }


        private void AddUser(object sender, RoutedEventArgs e)
        {
            User value = new User(users[^1].Id, TextName.Text, TextFamily.Text);
            value.Id++;
            users.Add(value);
            UserList.Items.Refresh();
        }

        private void Find_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        { 
        }

        private void TextName_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            Book value = new Book(books[^1].Act, TextBookName.Text, TextAuthor.Text, Convert.ToInt32(TextYear.Text), Convert.ToInt32(TextMounth.Text), Convert.ToInt32(TextDay.Text), Convert.ToInt32(TextCount.Text));
            value.Act++;
            books.Add(value);
            BookList.Items.Refresh();
        }

        private void Select_User(object sender, SelectionChangedEventArgs e)
        {
            User? value = UserList.SelectedItem as User;

            UserBook.ItemsSource = value.Books;
            UserBook.Items.Refresh();
        }
    }
}
