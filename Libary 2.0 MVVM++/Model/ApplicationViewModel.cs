using Lidary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delete_User_MVVM.Model
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private User selectedUser;

        public ObservableCollection<User> Users { get; set; }
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
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
