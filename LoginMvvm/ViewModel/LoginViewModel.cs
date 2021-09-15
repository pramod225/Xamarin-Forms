using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using LoginMvvm.Models;
using LoginMvvm.Services;
using LoginMvvm.Views;
using Realms;
using Xamarin.Forms;

namespace LoginMvvm.ViewModel
{
    public class LoginViewModel : LoginServices
    {
        
        RegistrationModel registration = new RegistrationModel();

        public Command LoginCommand { get; set; }
        public Command SignUp { get; set; }
        public INavigation Navigation { get; set; }

        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoginUser = new LoginModel();
            LoginCommand = new Command(ExecuteLogin);
            SignUp = new Command(SignUpAction);


        }

       public string Name { get; set; }

        private LoginModel userName;
        public LoginModel LoginUser
        {
            get { return userName; }
            set
            {
                userName = value; OnPropertyChanged("LoginUser");
            }
        }

        

        public void Getdata(string user, string password)
        {

            var realmDb = Realm.GetInstance();
            List<RegistrationModel> models = realmDb.All<RegistrationModel>().ToList();
            registration = models.Where(x => x.Email == user && x.Password == password).FirstOrDefault();

        }

        public void ExecuteLogin()
        {

           
            try
            {
                Getdata(LoginUser.UserName, LoginUser.Password);
                //if (string.IsNullOrEmpty(LoginUser.UserName) || string.IsNullOrEmpty(LoginUser.Password))
                //{
                //    App.Current.MainPage.DisplayAlert("Login", "Values Empty", "Ok");
                //}
                if (LoginUser.UserName == registration.Email || LoginUser.Password == registration.Password)
                {
                    Name = registration.FirstName + registration.LastName;

                    App.Current.MainPage.DisplayAlert("Saved", Name, "Ok");

                    LoginUser.Password = string.Empty;

                    var id = registration.Id;
                    App.UserId = id;

                    Navigation.PushAsync(new Views.MyAccountPage(Name));

                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Login", "Failed Login", "Ok");

                    LoginUser.Password = string.Empty;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : "+ ex);
            }

        }
        public ICommand TapCommand => new Command<string>((string model) =>
        {
            

        });

        public void SignUpAction()
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
