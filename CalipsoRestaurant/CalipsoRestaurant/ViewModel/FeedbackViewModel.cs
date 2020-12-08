using CalipsoRestaurant.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CalipsoRestaurant.ViewModel
{
    class FeedbackViewModel : BaseViewModel
    {
        public FeedbackViewModel()
        {
            Title = "Feedback";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
