using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endangered_animals.Utility
{
    public class ImageConverterHelper
    {
        public static ImageConverter imageConverter = new ImageConverter();

        public static byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ConvertByteArrayToImage(byte[] byteArray)
        {
            Bitmap bitmap = (Bitmap)imageConverter.ConvertFrom(byteArray);
            if (bitmap != null && (bitmap.HorizontalResolution != (int)bitmap.HorizontalResolution ||
                                    bitmap.VerticalResolution != (int)bitmap.VerticalResolution))
            {
                bitmap.SetResolution((int)(bitmap.HorizontalResolution + 0.5f), (int)(bitmap.VerticalResolution + 0.5f));
            }
            return bitmap;
        }
    }
}
