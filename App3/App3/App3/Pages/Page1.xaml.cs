using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3.Controls;
using App3.Models;
using Xamarin.Forms;

namespace App3.Pages
{
    /// <summary>
    /// not work on iOS
    /// </summary>
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            InfoList.ItemsSource = GetItems();

            Head.HeightRequest = App.ScreenHeight * 0.1;
            Body.HeightRequest = App.ScreenHeight * 0.5;

            Title = "Page 1";

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            DoSome();

            

            //MainLayout.ScaleTo(0.5, 5000, Easing.Linear);

            //Fly2();
        }

        private async void DoSome()
        {
            //await Task.Delay(2000);
            await MainImage.ScaleTo(3, 500, Easing.Linear);

            Fly2();
        }
        

        private async void Fly2()
        {
            var rdm = new Random();
            do
            {
                var w = rdm.Next(1, 100);
                var h = rdm.Next(1, 100);


                await MainImage.TranslateTo(w, h, 5000, Easing.Linear);
                await Task.Delay(1000);

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

        private void LayoutTouchListner_OnTouchEvent(object sender, EventArgs eventArgs)
        {
            var a = eventArgs as EvArg;

            //var res = sender as LayoutTouchListner;

            Debug.WriteLine("--------YTouch = " + a?.Val);
            Debug.WriteLine("--------Body.TranslationY = " + Body.TranslationY);

            //Body.TranslationY = (Body.TranslationY + (double)a.Val);

            var changeRequestBody = (Body.Height + (double) (a.Val*-1));
            if (changeRequestBody > (App.ScreenHeight * 0.5) && changeRequestBody < (App.ScreenHeight * 0.8))
            {
                LayoutTouchListnerCtrl.IsEnebleScroll = false;
                Body.HeightRequest = changeRequestBody;
            }
            else
            {
                LayoutTouchListnerCtrl.IsEnebleScroll = true;
            }

            //var changeRequestHead = (Head.Height + (double)(a.Val * -1));
            //if (changeRequestHead < defHeadHeight && changeRequestHead < (App.ScreenHeight * 0.3))
            //{
            //    Head.HeightRequest = changeRequestHead;
            //}

        }
    }
}
