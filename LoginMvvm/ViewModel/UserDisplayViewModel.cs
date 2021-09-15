using System;
namespace LoginMvvm.ViewModel
{
    public class UserDisplayViewModel
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
            }

        }
        public UserDisplayViewModel(string paramenter )
        {
            userName = paramenter;
        }
    }
}
