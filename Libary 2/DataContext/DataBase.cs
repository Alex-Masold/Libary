using Libary_2.Model;
using Lidary_2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Libary_2.DataContext
{
    class DataBase
    {
        public static ObservableCollection<User> Users = new()
        {
            new User {Family = "Рикотта", Name = "Сыр"},
            new User {Family = "Пробеловый", Name = "Пробел"},
            new User {Family = "Телефоновый", Name = "Телефон"},
            new User {Family = "Туц", Name = "Тунец"},
            new User {Family = "Космическая", Name = "Картошка"},
            new User {Family = "Шифрованный", Name = "Шарик"},
            new User {Family = "Бессмертный", Name = "Бульдозер"},
            new User {Family = "Лазерный", Name = "Лосось"},
            new User {Family = "Хлопавич", Name = "Флопа"},
            new User {Family = "Шлёпович", Name = "Шлёпа"},
            new User {Family = "Ашович", Name = "А"},
            new User {Family = "Бешович", Name = "Б"},
            new User {Family = "Вевовочи", Name = "В"},
            new User {Family = "Гегович", Name = "Г"}
        };

        public static ObservableCollection<Book> Books = new()
        {
            new Book {
                    Name = "Все о Yipppe",
                    Author = "?Александр Сидоров?",
                    Day = 1,
                    Month = 3,
                    Year = 2005
                },
                new Book {
                    Name = "Все о дединсайдах",
                    Author = "Андрей Найменко",
                    Day = 2,
                    Month = 08,
                    Year = 2077
                },
                new Book {
                    Name = "Все о чмоколадках",
                    Author = "Никита Честных",
                    Day = 27,
                    Month = 01,
                    Year = 2020
                },
                new Book {
                    Name = "Шепот карандаша",
                    Author = "Зелёный Кот",
                    Day = 20,
                    Month = 6,
                    Year = 2033
                },
                new Book {
                    Name = "Галактика чеснока",
                    Author = "Лунный Картошка",
                    Day = 12,
                    Month = 2,
                    Year = 2050
                },
                new Book {
                    Name = "Сны бульдозера",
                    Author = "Ржавый Ложка",
                    Day = 9,
                    Month = 12,
                    Year = 2018
                },
                new Book {
                    Name = "Шепот Космического Картофеля",
                    Author = "Злата Шарикова",
                    Day = 12,
                    Month = 7,
                    Year = 2033
                },
                new Book {
                    Name = "Танец Летающих Ёжиков",
                    Author = "Максим Галактиков",
                    Day = 5,
                    Month = 2,
                    Year = 2050
                },
                new Book {
                    Name = "Смех Оранжевой Галактики",
                    Author = "Луна Звездович",
                    Day = 19,
                    Month = 12,
                    Year = 2042
                },
                new Book {
                    Name = "Мечты капусты о парикмахере",
                    Author = "Буран Шариков",
                    Day = 25,
                    Month = 2,
                    Year = 2048
                },
                new Book {
                    Name = "Танцы томата в холодильнике",
                    Author = "Светлана Виллис",
                    Day = 12,
                    Month = 12,
                    Year = 2055
                },
                new Book {
                    Name = "Путешествие в космическую туалетную бумагу",
                    Author = "Иван Забытый",
                    Day = 15,
                    Month = 6,
                    Year = 2012
                },

                new Book {
                    Name = "Секреты успеха в выращивании картошки на Луне",
                    Author = "Екатерина Невероятная",
                    Day = 10,
                    Month = 11,
                    Year = 2025
                },

                new Book {
                    Name = "Искусство готовки с помощью телепортации",
                    Author = "Максим Безумный",
                    Day = 3,
                    Month = 4,
                    Year = 2030
                },
                new Book {
                    Name = "Шум внутри мышц",
                    Author = "Василий Звуков",
                    Day = 21,
                    Month = 7,
                    Year = 2033
                },
                new Book {
                    Name = "Крошечные камни вечности",
                    Author = "Ольга Перо",
                    Day = 12,
                    Month = 2,
                    Year = 2048
                },
                new Book {
                    Name = "Сказки о бетонных облаках",
                    Author = "Петр Щебетун",
                    Day = 30,
                    Month = 4,
                    Year = 2025
                }
        };

    }
}
