using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginMvvm
{
    public partial class App : Application
    { 
      public static string UserId { get; set; }
            public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            //Application.Current.Properties["id"] = UserId;

        }

        protected override void OnResume()
        {
        }
    }
}
