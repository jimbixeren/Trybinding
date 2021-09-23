using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trybinding.View;
using Xamarin.Forms;

namespace Trybinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MyBindingObject();
        }

        private void ToolbarItem_Clicked_Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }

        private void ToolbarItem_Clicked_Betmatch(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MatchbetPage());
        }
    }
}
