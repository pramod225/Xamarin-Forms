using System;
using LoginMvvm.iOS;
using LoginMvvm.Models;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonIos))]
namespace LoginMvvm.iOS
{
    public class RoundedButtonIos : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 20;
                this.Element.WidthRequest = 200;
             
            }
        }
    }
}
