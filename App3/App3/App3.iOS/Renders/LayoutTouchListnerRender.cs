using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using App3.Controls;
using App3.iOS.Renders;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LayoutTouchListner), typeof(LayoutTouchListnerRender))]
namespace App3.iOS.Renders
{
    [Preserve(AllMembers = true)]
    public class LayoutTouchListnerRender : ViewRenderer
    {
        LayoutTouchListner MainElement => (LayoutTouchListner)Element;
        private float difference;

        private bool touchStartedInside = false;
        //private CoreGraphics.CGRect originalImageFrame = CoreGraphics.CGRect.Empty;
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            UITouch touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                //originalImageFrame = this.Frame;
                touchStartedInside = true;
                //code here to handle touch
            }
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            base.TouchesMoved(touches, evt);
            // get the touch
            UITouch touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                // move the shape
                difference = (float)touch.PreviousLocationInView(this).Y - (float)touch.LocationInView(this).Y;
                System.Diagnostics.Debug.WriteLine("--------------dif = " + difference);
            }
        }
        
        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);
            // get the touch
            UITouch touch = touches.AnyObject as UITouch;
            if (touch != null)
            {
                MainElement.DoTouchEvent((difference / 10));
            }
            // reset our tracking flags
            touchStartedInside = false;
        }


        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (Element == null)
                return;
        }
    }
}
