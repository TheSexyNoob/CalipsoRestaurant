using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LaavorRatingConception;

namespace CalipsoRestaurant.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feedback : ContentPage
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void RatingConception_Voted(object sender, EventArgs e)
        {
            RatingConception rating = (RatingConception)sender;
            //int index = rating.IndexVoted;
            //int value = rating.Value;

            //index_star.Text = index.ToString();
            //value_star.Text = value.ToString();

            rating.InitialValue = 0; // Valor Por defecto
        }

        public Xamarin.Forms.Color BorderColor { get; set; }
    }
}