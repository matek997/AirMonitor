using System;
using System.ComponentModel;
using AirMonitor.Models;
using AirMonitor.ViewModels;
using Xamarin.Forms;

namespace AirMonitor.Views
{
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Measurement item)
        {
            InitializeComponent();

            var vm = BindingContext as DetailsViewModel;
            vm.Item = item;
        }

        private void Help_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("What is CAQI?", "The CAQI is a number on a scale from 1 to 100, where a low value means good air quality and a high value means bad air quality. ", "Close");
        }
    }
}
