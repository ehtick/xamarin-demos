#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SampleBrowser
{
    public class FoodSpecies : INotifyPropertyChanged
    {
        #region Fields

        private string speciesName;
        private ObservableCollection<FoodSpecies> species;

        #endregion

        #region Constructor

        public FoodSpecies()
        {
        }

        #endregion

        #region Properties

        public ObservableCollection<FoodSpecies> Species
        {
            get
            {
                return species;
            }

            set
            {
                species = value;
                RaisedOnPropertyChanged("Species");
            }
        }

        public string SpeciesName
        {
            get
            {
                return speciesName;
            }

            set
            {
                speciesName = value;
                RaisedOnPropertyChanged("SpeciesName");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}