using AdaSoftware.Database;
using AdaSoftware.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AdaSoftware.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        string username;
        string password;
        ImageSource imgSource;
        string loginStatus;
        ICommand loginCommand;
        ICommand signUpCommand;
        bool loayutIsVisible;
        bool isRunning;
        public MainPageViewModel()
        {
            ImgSource = ImageSource.FromResource("AdaSoftware.Images.xamarin.jpg");
            LoginCommand = new Command(loginFunction);
            SignUpCommand = new Command(singUpFunction);
            LoayutIsVisible = true;
        }

        public async void loginFunction()
        {
            IsRunning = true;
            USER u = await App.DBservice.LoginFunction(Username, Password);
            if (u == null)
            {
                LoginStatus = "Lohin Failed";
                IsRunning = false;
            }
            else
            {
                LoginStatus = "Login Successful";
                IsRunning = false;
                await App.Current.MainPage.Navigation.PushAsync(new OfferPage());
            }
        }

        public async void singUpFunction()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUp());

        }

        public string Username
        {
            get => username; set
            {
                if (username != value)
                    username = value;
            }
        }
        public string Password
        {
            get => password; set
            {
                if (password != value)
                    password = value;
            }
        }
        public ImageSource ImgSource
        {
            get => imgSource; set
            {
                if (imgSource != value)
                    imgSource = value;
            }
        }
        public string LoginStatus
        {
            get => loginStatus; set
            {
                if (loginStatus != value)
                {
                    loginStatus = value;
                    OnPropertyChanged("LoginStatus");
                }
            }
        }

        public ICommand LoginCommand { get => loginCommand; set => loginCommand = value; }
        public ICommand SignUpCommand { get => signUpCommand; set => signUpCommand = value; }
        public bool LoayutIsVisible
        {
            get => loayutIsVisible; set
            {

                if (loayutIsVisible != value)
                {
                    loayutIsVisible = value;
                    OnPropertyChanged("LoayutIsVisible");
                }

            }
        }
        public bool IsRunning
        {
            get => isRunning; set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    LoayutIsVisible = !isRunning;
                    OnPropertyChanged("IsRunning");

                }

            }
        }
    }
}
