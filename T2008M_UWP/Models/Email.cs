using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
namespace T2008M_UWP.Models
{
    class Email
    {
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public BitmapImage Img { get; set; }
    }
}