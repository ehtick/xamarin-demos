#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Android.Content;
using Android.Graphics;
using SampleBrowser.SfPdfViewer;
using SampleBrowser.SfPdfViewer.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))] 
namespace SampleBrowser.SfPdfViewer.Droid
{
    class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context){ }
        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
				
                if (Control != null)
#pragma warning disable CS0618 // Type or member is obsolete
                    Control.Background.SetColorFilter(Android.Graphics.Color.Rgb(0, 118, 255), PorterDuff.Mode.SrcAtop);
#pragma warning restore CS0618 // Type or member is obsolete
                var nativeEditText = (global::Android.Widget.EditText)Control;
                nativeEditText.SetSelectAllOnFocus(true);
            }
        }
    }
}