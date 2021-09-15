using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LoginMvvm.Models;
using LoginMvvm.ViewModel;
using Realms;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LoginMvvm.Views
{
    public partial class RegisterPage : ContentPage
    {
        RegisterViewModel _RegisterViewModel;
        

        public RegisterPage()
        {
            InitializeComponent();
           _RegisterViewModel = new RegisterViewModel(Navigation);
            BindingContext = _RegisterViewModel;

        }

        public RegisterPage(RegistrationModel model)
        {
            InitializeComponent();
            _RegisterViewModel = new RegisterViewModel(Navigation);
            BindingContext = _RegisterViewModel;
            _RegisterViewModel.isUpdatePage = true;
            if (model is object)
            {
               _RegisterViewModel.realmObjectId = model.Id;
                firstName.Text = model.FirstName;
                lastName.Text = model.LastName;
                email.Text = model.Email;
                password.Text = model.Password;
                password.IsEnabled = false;
                cpassword.Text = model.Password;
                cpassword.IsVisible = false;
                if (male.IsChecked)
                {
                    male.IsEnabled = false;
                }
                else if (female.IsChecked) { female.IsEnabled = false; }
                else {
                    other.IsEnabled = false;
                }
              
              
                phoneNo.Text = model.PhoneNo;
                saveButton.Text = "Update";
                this.Title = "Edit Information";
            }
        }


        void RadioButton_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            var radio = sender as RadioButton;

            if (radio.IsChecked)
            {
                string gender = radio.Content.ToString();
                _RegisterViewModel.RadioButton.Execute(gender);
            }
        }
       
    }
}


