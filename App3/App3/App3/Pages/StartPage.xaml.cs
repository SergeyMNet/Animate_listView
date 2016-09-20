using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3.Pages
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Button3_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void Button4_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}
