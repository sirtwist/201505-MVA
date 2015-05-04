﻿using AdaptiveUI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdaptiveUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            // Intialize xaml
            this.InitializeComponent();
        }

        private void SampleGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var 
            //await Windows.Graphics.Printing.PrintManager.ShowPrintUIAsync();

            // Which sample?
            var sample = (SampleInfo)e.ClickedItem;

            // Go!
            Frame.Navigate(sample.Type);
        }
    }
}