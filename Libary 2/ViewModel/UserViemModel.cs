using Lidary_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delete_User_MVVM.ViewModel
{
    internal class UserViemModel
    {
        public class PhoneViewModel : INotifyPropertyChanged
        {
            private User user;

            public PhoneViewModel(User u)
            {
                user = u;
            }

            public string Name
            {
                get { return user.Name; }
                set
                {
                    user.Name = value;
                    OnPropertyChanged("Name");
                }
            }
            public string Fammily
            {
                get { return user.Family; }
                set
                {
                    user.Family = value;
                    OnPropertyChanged("Family");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
