﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Bestiary.Classes;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bestiary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EntryInformation : Page
    {
        public EntryInformation()
        {
            this.InitializeComponent();
            var path = Path.GetFullPath(EntriesDone.SelectedEntry.ImagePath);
            BitmapImage bitmap = new BitmapImage();
            bitmap.UriSource = new Uri(@""+path, UriKind.Relative);
            img_entry.Source = bitmap;
            img_entry.Opacity = 0.40;
            img_entry.MaxWidth = 500;
            img_entry.MaxHeight = 500;
            
            





        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SelectedEntryMenu));
        }
    }
}
