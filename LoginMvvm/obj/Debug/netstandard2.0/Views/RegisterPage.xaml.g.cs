//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("LoginMvvm.Views.RegisterPage.xaml", "Views/RegisterPage.xaml", typeof(global::LoginMvvm.Views.RegisterPage))]

namespace LoginMvvm.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views/RegisterPage.xaml")]
    public partial class RegisterPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.RoundedEntry firstName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.RoundedEntry lastName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.RoundedEntry email;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.RoundedEntry password;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.RoundedEntry cpassword;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.DatePicker dob;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.RadioButton male;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.RadioButton female;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.RadioButton other;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.RoundedEntry phoneNo;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.CheckBox checkAgree;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LoginMvvm.Models.RoundedButton saveButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(RegisterPage));
            firstName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.RoundedEntry>(this, "firstName");
            lastName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.RoundedEntry>(this, "lastName");
            email = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.RoundedEntry>(this, "email");
            password = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.RoundedEntry>(this, "password");
            cpassword = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.RoundedEntry>(this, "cpassword");
            dob = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.DatePicker>(this, "dob");
            male = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.RadioButton>(this, "male");
            female = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.RadioButton>(this, "female");
            other = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.RadioButton>(this, "other");
            phoneNo = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.RoundedEntry>(this, "phoneNo");
            checkAgree = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.CheckBox>(this, "checkAgree");
            saveButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LoginMvvm.Models.RoundedButton>(this, "saveButton");
        }
    }
}
