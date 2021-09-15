using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LoginMvvm.Services
{
    public class LoginServices :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

    }
}
