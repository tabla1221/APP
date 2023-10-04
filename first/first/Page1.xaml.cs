using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace first
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
        }

        public Page1(string pas)
        {
            InitializeComponent();
            h.Text = "hi ms "  + pas;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();  
        }
    }
}