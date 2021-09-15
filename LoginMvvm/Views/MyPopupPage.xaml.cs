using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPopupPage : PopupPage
    {
        public MyPopupPage()
        {
            InitializeComponent();
        }

        void Close_Clicked(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

    }
}
