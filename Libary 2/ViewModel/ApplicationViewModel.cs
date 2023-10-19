using System.Collections.ObjectModel;
using Libary_2.Model;
using Lidary_2.Model;

namespace Libary_2.ViewModel
{

    public class ApplicationViewModel : PropPropertyChanged
    {
        private User selectedUser;

        public ObservableCollection<User> Users { get; set; }

        private RelayCommand addComand;
        public RelayCommand AddComand
        {
            get
            {
                return addComand ??
                    (addComand = new RelayCommand(obj =>
                    {
                        User user = new User();
                        Users.Add(user);
                        SelectedUser = user;
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
        public ApplicationViewModel()
        {
            Users = new ObservableCollection<User>
            {
            new User {Family = "Рикотта", Name = "Сыр"},
            new User {Family = "Пробеловый", Name = "Пробел"},
            new User {Family = "Телефоновый", Name = "Телефон"},
            new User {Family = "Туц", Name = "Тунец"}
            };
        }
    }
}
