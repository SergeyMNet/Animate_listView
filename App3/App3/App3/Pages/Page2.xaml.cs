using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3.Models;
using Xamarin.Forms;

namespace App3.Pages
{
    /// <summary>
    /// not work on iOS
    /// </summary>
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            Title = "Page 2 - header animation";
            Head.HeightRequest = App.ScreenHeight*0.3;
            InfoList.ItemsSource = GetItems();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DoSome();
        }

        private async void DoSome()
        {
            await MainImage.ScaleTo(2, 500, Easing.Linear);

            Fly();
        }


        private async void Fly()
        {
            var rdm = new Random();
            do
            {
                var w = rdm.Next(1, 100);
                var h = rdm.Next(1, 100);
                
                    MainImage.TranslateTo(w, h, 5000, Easing.Linear);
                    if (w % 2 == 0)
                    {
                        MainImage.ScaleTo(3, 5000, Easing.Linear);
                    }
                    else
                    {
                        MainImage.ScaleTo(2, 5000, Easing.Linear);
                    }
                


                await Task.Delay(5000);

                //await MainImage.TranslateTo(Math.Abs(w), Math.Abs(h), 5000, Easing.Linear);

            } while (true);
        }


        private List<Item> GetItems()
        {
            var list = new List<Item>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(new Item("item " + i, i));
            }
            return list;
        }

        private void InfoList_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var x = Head.X;
            Debug.WriteLine("-----x = " + x);
        }
    }
}
