using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFShellLoginFlow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
            }
        }

        private string _message;
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Login process
            //Check username and password etc..
            if (CheckUser(this.UserName, this.Password))
                App.Current.MainPage = new AppShell();
            else
                this.Message = "Wrong username or password.";
        }

        private bool CheckUser(string userName, string password)
        {
            if (userName == "aaa" && password == "bbb")
                return true;
            else
                return false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegistrationPage();
        }
    }
}