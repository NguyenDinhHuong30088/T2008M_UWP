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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP.pages.Lab1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class labs1 : Page
    {
        public StackPanel allEmailsPanel;
        public labs1()
        {
            this.InitializeComponent();
            allEmailsPanel = new StackPanel();
            allEmailsPanel.HorizontalAlignment = HorizontalAlignment.Left;
            allEmailsPanel.VerticalAlignment = VerticalAlignment.Top;
        }
        public Border GetMyBorder(int left, int top, int right, int bottom)
        {
            Border myBorder = new Border();
            myBorder.BorderThickness = new Thickness(left, top, right, bottom);
            myBorder.Padding = new Thickness(10);
            myBorder.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
            return myBorder;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

            TextBlock email = new TextBlock();
            TextBlock title = new TextBlock();
            TextBlock content = new TextBlock();
            email.TextWrapping = TextWrapping.Wrap;
            title.TextWrapping = TextWrapping.Wrap;
            content.TextWrapping = TextWrapping.Wrap;

            email.Text = "Email Nhận: " + inputEmail.Text;
            title.Text = "Tiêu đề: " + inputTitle.Text;
            content.Text = "Nội dung: " + inputContent.Text;

            StackPanel emailPanel = new StackPanel();
            emailPanel.HorizontalAlignment = HorizontalAlignment.Left;
            emailPanel.VerticalAlignment = VerticalAlignment.Top;
            emailPanel.Margin = new Thickness(0, 0, 0, 20);

            Border emailBorder = GetMyBorder(3, 3, 3, 0);
            emailBorder.Child = email;
            Border titleBorder = GetMyBorder(3, 3, 3, 0);
            titleBorder.Child = title;
            Border contentBorder = GetMyBorder(3, 3, 3, 3);
            contentBorder.Child = content;
            emailPanel.Children.Add(emailBorder);
            emailPanel.Children.Add(titleBorder);
            emailPanel.Children.Add(contentBorder);
            emailPanel.Width = 500;


            allEmailsPanel.Children.Insert(0, emailPanel);

            scrollViewer.Content = allEmailsPanel;
        }
    }
}