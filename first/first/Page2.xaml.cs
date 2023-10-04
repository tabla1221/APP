using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace first
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(nam.Text))
            {
                await DisplayAlert("warning", "please add your name", "ok");
                return;
            }
            if (string.IsNullOrEmpty(email.Text)) 
            {
                await DisplayAlert("warning", "please add your ne", "ok");
                return;
            }
             await Navigation.PopAsync();   
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var P = Connectivity.NetworkAccess;
            if (P == NetworkAccess.None)
            {
                await DisplayAlert("Erore", " please cheack your connection", "ok");
                return;
            }

            await Navigation.PushAsync(new Page3());
        }
        protected override  bool OnBackButtonPressed()
        {
            //return base.OnBackButtonPressed();
             DisplayAlert("hay", "al miftah mouch chgal", "ok");
            return true;
        }
    }
}