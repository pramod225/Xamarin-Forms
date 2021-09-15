using System;
using System.Collections.Generic;
using LoginMvvm.ViewModel;
using Xamarin.Forms;

namespace LoginMvvm.Views
{
    public partial class MyAccountPage :ContentPage
    {
        public string Name;
        public string FullName
        {
            get { return Name; }
            set
            {
                Name = value;
                OnPropertyChanged();
            }
        }

        public MyAccountPage(string name)
        {
            InitializeComponent();
            BindingContext = new ViewModel.UserDisplayViewModel(name);
           
           
        }
      
       

    }
}
