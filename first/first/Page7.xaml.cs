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
    public partial class Page7 : TabbedPage
    {
        public Page7()
        {
            InitializeComponent();
         
                




        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }
    }
}