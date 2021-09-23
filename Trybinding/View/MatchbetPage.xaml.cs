using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace Trybinding.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchbetPage : ContentPage
    {
        public MatchbetPage()
        {
            InitializeComponent();
        }


       


        private void Button_Clicked(object sender, EventArgs e)
        {

            //string Tryheader = save.Text;

            //var entry = new Entry { Placeholder = "Enter a team", PlaceholderColor = Color.Olive };



            //string text = save.Text;

            Navigation.PopAsync();
        }
    }
}