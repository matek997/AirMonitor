using System;
using System.Collections.Generic;
using AirMonitor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AirMonitor.Views
{
    public partial class MapPage : ContentPage
    {
        private HomeViewModel _viewModel => BindingContext as HomeViewModel;
        public MapPage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel(Navigation);
        }
        public void InfoWindow_ItemTapped(System.Object sender, Xamarin.Forms.Maps.PinClickedEventArgs e)
        {
            if(sender is Pin pin)
            {
                _viewModel.GoToMapDetailsCommand.Execute((sender as Xamarin.Forms.Maps.Pin).Address);
            }
            
        }
    }
}
