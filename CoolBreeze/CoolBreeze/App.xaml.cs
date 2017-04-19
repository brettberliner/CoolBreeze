using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CoolBreeze
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel;
        public static string RegistrationCode = "XBWW24C8DAA797CFF7469E33E0816EEB";

        public App()
        {
            InitializeComponent();

            MainPage = new CoolBreeze.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
