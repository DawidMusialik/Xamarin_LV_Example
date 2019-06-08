using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Example
{
    public partial class App : Application
    {
        public App()
        {

            MainPage = new NavigationPage(new StartPage());
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
