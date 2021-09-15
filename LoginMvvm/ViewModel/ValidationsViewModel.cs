using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace LoginMvvm.ViewModel
{
    public class ValidationsViewModel : TriggerAction<Entry>
    {

        protected override void Invoke(Entry entry)
        {
            const string emailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            string email = entry.Text;
            if (!Regex.IsMatch(email, emailPattern))
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


