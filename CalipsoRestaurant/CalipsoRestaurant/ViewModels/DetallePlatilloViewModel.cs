using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CalipsoRestaurant.ViewModels
{
    class DetallePlatilloViewModel : BaseViewModel
    {
        public DetallePlatilloViewModel()
        {
            Title = "Detalle Platillo";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
