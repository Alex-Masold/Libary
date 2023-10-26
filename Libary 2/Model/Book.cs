using System.Collections.ObjectModel;

namespace Libary_2.Model
{
    public class Book : PropPropertyChanged
    {
        private static short _uniqueId = 0;

        private int id = _uniqueId;
        private string name;
        private string author;
        private int day;
        private int month;
        private int year;
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
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }
        public int Day
        {
            get { return day; }
            set
            {
                day = value;
                OnPropertyChanged("Day");
                OnPropertyChanged("Age");
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                month = value;
                OnPropertyChanged("Month");
                OnPropertyChanged("Age");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged("Year");
                OnPropertyChanged("Age");
            }
        } 
        public string Age
        {
            get
            {
                return $"{day:D2}/{month:D2}/{year:D4}"; // Форматируем строку в виде "дд/мм/гггг"
            }
            set
            {
                // Разбиваем строку на отдельные компоненты
                string[] components = value.Split('/');
                if (components.Length == 3 &&
                    int.TryParse(components[0], out int parsedDay) &&
                    int.TryParse(components[1], out int parsedMonth) &&
                    int.TryParse(components[2], out int parsedYear))
                {
                    day = parsedDay;
                    month = parsedMonth;
                    year = parsedYear;
                    OnPropertyChanged("Age");
                }
                else
                {
                    // Обработка ошибки ввода, если формат строки неверен
                    // Можно добавить логику по обработке ошибок ввода
                }
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
                if (examples != null)
                {
                    examples.CollectionChanged -= Examples_CollectionChanged;
                }

                examples = value;

                if (examples != null)
                {
                    examples.CollectionChanged += Examples_CollectionChanged;
                }

                OnPropertyChanged("Examples");
                OnPropertyChanged("Count");
            }
        }
        private void Examples_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("Count");
        }
        public Book()
        {
            _uniqueId++;
            Id = _uniqueId;
            Examples = new();
        }
    }
}
