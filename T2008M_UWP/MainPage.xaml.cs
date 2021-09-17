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
using T2008M_UWP.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2008M_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame _mainFrame;
        public MainPage()
        {
            this.InitializeComponent();
            _mainFrame = MainFrame;
            MainFrame.Navigate(typeof(pages.Mail));
        }


        private void HomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(pages.Home));
        }
        private void PersonInfo(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(pages.PersonInfomation));
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Person Infomation", MenuPage = "pi", Icon = "\uE946" };
            // Gia su co 1 danh sach category
            // new MenuItem() { Name = "Ten cua category", MenuPage = "category", Icon = "\uE946" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(pages.Home), selectedItem); break; // Page
                case "pi": MainFrame.Navigate(typeof(pages.PersonInfomation)); break;
                    //case "category": MainFrame.Navigate(typeof(Pages.Category),category); break;
            }
        }
    }
}