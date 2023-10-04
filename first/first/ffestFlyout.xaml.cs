using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace first
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ffestFlyout : ContentPage
    {
        public ListView ListView;

        public ffestFlyout()
        {
            InitializeComponent();

            BindingContext = new ffestFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class ffestFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ffestFlyoutMenuItem> MenuItems { get; set; }

            public ffestFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ffestFlyoutMenuItem>(new[]
                {
                    new ffestFlyoutMenuItem { Id = 0, Title = "MainPage"  , TargetType=typeof(MainPage) },
                    new ffestFlyoutMenuItem { Id = 1, Title = "callPage" , TargetType=typeof(Page5) },
                    new ffestFlyoutMenuItem { Id = 2, Title = "carouslepage" , TargetType = typeof(Page6)},
                   
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}