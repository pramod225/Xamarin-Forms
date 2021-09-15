using System;
using CoreAnimation;
using CoreGraphics;
using LoginMvvm;
using LoginMvvm.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(RoundedEntry),typeof(RoundedEntryios))]
namespace LoginMvvm.iOS
{
    public class RoundedEntryios :EntryRenderer
    {
        private CALayer borderLayer;
        int sublayerNumber = 0;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
                borderLayer = new CALayer();
                Control.Layer.AddSublayer(borderLayer);
                sublayerNumber = Control.Layer.Sublayers.Length - 1;
            }
        }
            
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
           
            Control.Layer.Sublayers[sublayerNumber].MasksToBounds = false;
            
            Control.Layer.Sublayers[sublayerNumber].Frame = new CoreGraphics.CGRect(0f, Frame.Height - -10, Frame.Width, 2f);
            Control.Layer.Sublayers[sublayerNumber].BorderColor = Color.FromHex("#C0C0C0").ToCGColor();
            Control.Layer.Sublayers[sublayerNumber].BorderWidth = 20.0f;
           
        }
        
    }
}
