using System;
using System.Text.RegularExpressions;
using LoginMvvm.Models;
using Xamarin.Forms;

namespace LoginMvvm.ViewModel
{
    public class PasswordValidations : TriggerAction<Entry>
    {
       
        //public string password { get; set; }

        protected override void Invoke(Entry entry)
        {
            var pass = entry.BindingContext as string;

            if (entry.Text != pass)
            {
                entry.BackgroundColor = Color.Red;
            }
            else
            {
                entry.BackgroundColor = Color.White;
            }
        }
    }
   
    
    
    
}
