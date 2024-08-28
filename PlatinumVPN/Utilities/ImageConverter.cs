using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatinumVPN.Utilities
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            try
            {
                //byte[] str = Encoding.UTF8.GetBytes(value.ToString());
                if (value == null)
                    return new object();
                //byte[] icon;
                //using (FileStream fs = new FileStream("D:\\CaGoCompany\\New\\CarGo\\CarGo\\CarGo\\Assets\\header.jpg", FileMode.Open))
                //{
                //  icon = new byte[fs.Length];
                // fs.Read(icon, 0, icon.Length);
                //}
                ByteString d = (ByteString)value;
                byte[] r = d.ToByteArray();
                Bitmap bImg = new Bitmap(new MemoryStream(r));
                // Bitmap bImg = new Bitmap(new MemoryStream(byte[] va));
                return bImg;
            }
            catch
            {
                return new object();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
