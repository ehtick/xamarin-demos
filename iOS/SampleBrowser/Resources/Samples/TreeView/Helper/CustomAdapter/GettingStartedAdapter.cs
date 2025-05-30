#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using UIKit;
using Syncfusion.iOS.TreeView;

namespace SampleBrowser
{
    public class GettingStartedAdapter : TreeViewAdapter
    {
        public GettingStartedAdapter()
        {

        }
        protected override void UpdateContentView(UIView view, TreeViewItemInfoBase itemInfo)
        {
            var label = view as UILabel;
            if (label != null)
                label.Text = (itemInfo.Node.Content as FoodSpecies).SpeciesName;
        }
    }
}