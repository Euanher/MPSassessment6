using System;
using Xamarin.Forms;


namespace Login.Details
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginDetails.Pages.LoginPage();
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
