using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3.Controls
{
    public class SearchPageViewCellWithId : ViewCell
    {
        public SearchPageViewCellWithId()
        {

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ItemId == 1)
            {
                DoFirstApper();

                if (MaxId > 9)
                {
                    DoLastDisapp();
                }
                else
                {
                    DoLastApper();
                }
            }
            else if (ItemId == MaxId)
            {
                DoLastApper();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (ItemId == 1)
            {
                DoFirstDisapp();
            }
            else if (ItemId == MaxId)
            {
                DoLastDisapp();
            }
        }

        public event EventHandler FirstDisapp;
        public void DoFirstDisapp()
        {
            EventHandler eh = FirstDisapp;
            if (eh != null)
                eh(this, EventArgs.Empty);
        }


        public event EventHandler FirstApper;
        public void DoFirstApper()
        {
            EventHandler eh = FirstApper;
            if (eh != null)
                eh(this, EventArgs.Empty);
        }



        public event EventHandler LastDisapp;
        public void DoLastDisapp()
        {
            EventHandler eh = LastDisapp;
            if (eh != null)
                eh(this, EventArgs.Empty);
        }


        public event EventHandler LastApper;
        public void DoLastApper()
        {
            EventHandler eh = LastApper;
            if (eh != null)
                eh(this, EventArgs.Empty);
        }





        public static readonly BindableProperty ItemIdProperty =
            BindableProperty.Create("ItemId", typeof(Int32),
                typeof(SearchPageViewCellWithId), 0, BindingMode.TwoWay, null, null);

        public int ItemId
        {
            get { return (Int32)GetValue(ItemIdProperty); }
            set { SetValue(ItemIdProperty, value); }
        }


        public static readonly BindableProperty MaxIdProperty =
            BindableProperty.Create("MaxId", typeof(Int32),
                typeof(SearchPageViewCellWithId), 0, BindingMode.TwoWay, null, null);

        public int MaxId
        {
            get { return (Int32)GetValue(MaxIdProperty); }
            set { SetValue(MaxIdProperty, value); }
        }
    }
}
