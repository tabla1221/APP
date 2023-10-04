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
    public partial class Page6 : CarouselPage
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page7());
        }
    }
}