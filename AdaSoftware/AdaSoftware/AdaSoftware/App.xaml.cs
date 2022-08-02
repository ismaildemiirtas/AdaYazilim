using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AdaSoftware.Views;
using AdaSoftware.Services;
using System.IO;

namespace AdaSoftware
{
    public partial class App : Application
    {
        private static DBservice dBservice;
        public static DBservice DBservice { get => dBservice; set => dBservice = value; }
        public static object UserService { get; internal set; }
        public static object InsuranceService { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            DBservice = new DBservice(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "xamarinDB.db3"));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
