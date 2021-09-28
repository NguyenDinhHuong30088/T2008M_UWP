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
using Windows.UI.Xaml.Media.Imaging;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            GV.Items.Add(new Email() { Mail = "nguyendinhhuong3008@gmail.com", Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg")) });
            GV.Items.Add(new Email() { Mail = "nguyendinhhuong30088@gmail.com", Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg")) });
            GV.Items.Add(new Email() { Mail = "nguyendinhhuong30008@gmail.com", Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg")) });
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) // hàm này thực thi khi có sự kieenn navigate đến page nay
        {
            MenuItem item = e.Parameter as MenuItem;
            Title.Text = item.Name;
        }
    }
}