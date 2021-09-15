using System;
using System.Collections.Generic;
using System.Linq;
using LoginMvvm.Models;
using LoginMvvm.ViewModel;
using Realms;
using Xamarin.Forms;

namespace LoginMvvm.Views
{
    public partial class HomePage : ContentPage
    {
        RegisterViewModel _RegisterViewModel;
        public HomePage()
        {
           
            InitializeComponent();
            _RegisterViewModel= new RegisterViewModel(Navigation);
            BindingContext = _RegisterViewModel;
        }
       
        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            RegistrationModel details = e.Item as RegistrationModel;
            if (details != null)
            {
                Navigation.PushAsync(new RegisterPage(details));
            }
        }
    }
}
