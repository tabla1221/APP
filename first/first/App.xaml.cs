using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Xamarin.Forms;
// using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.Xaml;





namespace first
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage ()) 
            { 
            
            };
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
