using System;
using System.Collections.Generic;
using LoginMvvm.ViewModel;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace LoginMvvm.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

        void  TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushPopupAsync(new Views.MyPopupPage());
            
        }

        
    }
}
