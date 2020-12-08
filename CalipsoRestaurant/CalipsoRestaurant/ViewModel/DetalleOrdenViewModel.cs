using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CalipsoRestaurant.ViewModel
{
    class DetalleOrdenViewModel : BaseViewModel
    {
        public DetalleOrdenViewModel()
        {
            Title = "Detalle Orden";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}