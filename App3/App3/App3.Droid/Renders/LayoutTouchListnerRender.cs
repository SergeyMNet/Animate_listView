using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App3.Controls;
using App3.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Xamarin.Forms.View;

[assembly: ExportRenderer(typeof(LayoutTouchListner), typeof(LayoutTouchListnerRender))]
namespace App3.Droid.Renders
{
    public partial class LayoutTouchListnerRender : ViewRenderer
    {
        private LayoutTouchListner MainElement;

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            MainElement = Element as LayoutTouchListner;
        }
        
        private static float _start;
        private static float _end;

        public override bool DispatchTouchEvent(MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    _start = e.GetY();
                    break;

                case MotionEventActions.Move:

                    _end = e.GetY();
                    float difference = _end - _start;
                    MainElement.DoTouchEvent((difference/10));
                    break;
            }
            
            if (MainElement.IsEnebleScroll)
            {
                return base.DispatchTouchEvent(e);
            }
            else
            {
                return true;
            }

        }

        protected override void OnAnimationEnd()
        {
            base.OnAnimationEnd();

            this.LayoutParameters = new LayoutParams(
            Android.Widget.LinearLayout.LayoutParams.FillParent,
            Android.Widget.LinearLayout.LayoutParams.WrapContent);
        }
    }
}