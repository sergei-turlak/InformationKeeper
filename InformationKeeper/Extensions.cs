using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace InformationKeeper
{
    static class Extensions
    {
        public static byte[] GetBytes(this string str, byte key)
        {
            byte[] arr = Encoding.Default.GetBytes(str);
            byte[] res = new byte[arr.Length];
            for (int i = 0; i < res.Length; i++)
                res[i] = Convert.ToByte(arr[i] ^ key);
            return res;
        }

        public static string GetString(this byte[] arr, byte key)
        {
            byte[] res = new byte[arr.Length];
            for (int i = 0; i < res.Length; i++)
                res[i] = Convert.ToByte(arr[i] ^ key);
            return Encoding.Default.GetString(res);
        }

        public static List<byte[]> Encrypt(this List<byte[]> images, byte key)
        {
            List<byte[]> list = new List<byte[]>();
            for (int i = 0; i < images.Count; i++)
            {
                for (int j = 0; j < images[i].Length; j++)
                    images[i][j] = Convert.ToByte(images[i][j] ^ key);
                list.Add(images[i]);
            }
            return list.ToList();
        }

        public static Image GetImage(this byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
                return Image.FromStream(ms);
        }

        public static byte[] GetBytes(this Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(image);
                bitmap.Save(ms, image.RawFormat == ImageFormat.Png ? ImageFormat.Jpeg : ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
