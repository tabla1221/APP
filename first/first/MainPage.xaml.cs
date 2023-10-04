using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace first
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(us.Text) && string.IsNullOrEmpty(pas.Text)){
                await DisplayAlert("warning", "ur pass and ur name are empty or incorrect", "ok");
                return;
            }
            if (string.IsNullOrEmpty(us.Text))
            {
                await DisplayAlert("warning", "ur name incorrect or empty ", "ok");
                return;
            }
                if (string.IsNullOrEmpty(pas.Text))
                {
                    await DisplayAlert("warning", "ur pass incorrect or empty", "ok");
                    return;
                }
                await Navigation.PushAsync(new Page1(us.Text));
            }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await DisplayAlert("nseti password?", "wahhhh d3ti ma3ndi manderlik", "OKhhhh");

        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
          await  Navigation.PushAsync(new Page7());
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ffest());
        }
    }

      
        }
    

