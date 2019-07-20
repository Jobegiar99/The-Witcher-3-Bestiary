using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bestiary
{
   
    
    public sealed partial class SelectedEntryMenu : Page
    {

        public dynamic SelectedEntry { get; set; }
            
        

        public SelectedEntryMenu()
        {
            
            this.InitializeComponent();
            List<Button> buttonList = new List<Button>() {
                button_entry1,
                button_entry2,
                button_entry3,
                button_entry4,
                button_entry5,
                button_entry6,
                button_entry7,
                button_entry8,
                button_entry9,
                button_entry10,
                button_entry11,
                button_entry12,
                button_entry13,
                button_entry14,
                button_entry15,
                button_entry16,
                button_entry17,
                button_entry18,
                button_entry19,
                button_entry20};
          
            txt_title.Text = EntriesDone.SelectedEntryType;
            byte listIndex = 0;
            foreach(Entry entry in EntriesDone.SelectedEntry)
            {
                buttonList[listIndex].Content = entry.Name;
                listIndex++;
            }
            while (listIndex < 20)
            {
                buttonList[listIndex].Visibility = Visibility.Collapsed;
                listIndex++;
            }
        }

        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
