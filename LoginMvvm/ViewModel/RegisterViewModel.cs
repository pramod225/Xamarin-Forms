using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using LoginMvvm.Models;
using LoginMvvm.Services;
using LoginMvvm.Views;
using Realms;
using Xamarin.Forms;

namespace LoginMvvm.ViewModel
{
    public class RegisterViewModel : LoginServices
    {
        
        public Command SaveCommand { get; set; }
        public Command RadioButton { get; set; }
        public Command ShowList { get; set; }
        public INavigation Navigation { get; set; }
        public bool isUpdatePage = false;
        public string realmObjectId;
        public ICommand ExpandCommand { get; private set; }
        public ObservableCollection<RegistrationModel> models { get; private set; }

        public bool IsExpanded { get; set; }
        public string Message { get; private set; }

        public RegisterViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Register = new RegistrationModel();
            SaveCommand = new Command(ExecuteButtonClicked);
            RadioButton = new Command((gender) => ExecuteRadio(gender.ToString()));
            ShowList = new Command(Showdata);
            ImagesList = new List<string>
            {
                "outrun-vaporwave-hd-wallpaper-preview.jpeg",
                "pexels-photo-2486168.jpeg",
                "digital-digital-art-artwork-illustration-abstract-hd-wallpaper-thumb.jpeg",
                "download.jpeg"
            };
            ImagesList = imagesList;

        }

        private IEnumerable<string> imagesList;
        public IEnumerable<string> ImagesList
        {
            get { return imagesList; }
            set
            {
                imagesList = value;
            }
        }

        public RegisterViewModel()
        {
            Showdata();
            ExpandCommand = new Command<RegistrationModel>(Expand);
            IsExpanded = true;
        }

        void Expand(RegistrationModel model)
        {
            Message = $"{model.FirstName} tapped.";
            OnPropertyChanged("Message");
        }

        ObservableCollection<RegistrationModel> dataList;
        public ObservableCollection<RegistrationModel> DataList
        {
            get { return dataList; }
            set
            {
                dataList = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(DataList));
            }
        }

        private RegistrationModel register;
        public string listregister;

        public RegistrationModel Register
        {
            get { return register; }
            set
            {
                register = value; OnPropertyChanged("Register");
            }
        }

        
        public void ExecuteButtonClicked()
        {
            if (isUpdatePage)
            {
                UpdateUser();
            }
            else
            {
                RegisterUser();
            }

        }

        private void RegisterUser()
        {
            var realmDb = Realm.GetInstance();
            //var registerId = realmDb.All<RegistrationModel>().Count() + 1;
            var model = new RegistrationModel()
            {

                Id = Guid.NewGuid().ToString(),
                FirstName = Register.FirstName,
                LastName = Register.LastName,
                Email = Register.Email,
                Password = Register.Password,
                Dob = Register.Dob,
                Gender = Register.Gender,
                PhoneNo = Register.PhoneNo
            };
            realmDb.Write(() =>
            {
                model = realmDb.Add(model);

            });

            App.Current.MainPage.DisplayAlert("Saved", "", "Ok");

            Register.FirstName = string.Empty;
            Register.LastName = string.Empty;
            Register.Email = string.Empty;
            Register.Password = string.Empty;
            Register.Dob = DateTime.Now.Date.ToString();
            Register.PhoneNo = string.Empty;
            Navigation.PushAsync(new Views.LoginPage());
        }

        public void UpdateUser()
        {
            var realmDb = Realm.GetInstance();
            var model = new RegistrationModel();
            model.Id = realmObjectId;
            model.FirstName = Register.FirstName;
            model.LastName = Register.LastName;
            model.Email = Register.Email;
            model.Password = Register.Password;
            model.Dob = Register.Dob;
            model.Gender = Register.Gender;
            model.PhoneNo = Register.PhoneNo;

            realmDb.Write(() =>
            {
                realmDb.Add(model, true);

            });
            App.Current.MainPage.DisplayAlert("Updated", "", "Ok");
            realmObjectId = null;
            isUpdatePage = false;
        }

        public ICommand DeleteCommand => new Command<RegistrationModel>((RegistrationModel model) =>
        {
            var realmDb = Realm.GetInstance();
            realmDb.Write(() =>
            {
                realmDb.Remove(model);
            });
            Showdata();

        });

        public void Showdata()
        {
            var realmDb = Realm.GetInstance();
            var models = realmDb.All<RegistrationModel>();
            DataList = new ObservableCollection<RegistrationModel>(models);

        }

        public void ExecuteRadio(string gender)
        {

            Register.Gender = gender;
        }
       
    }
}
