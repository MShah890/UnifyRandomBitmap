using System;
using System.Net.Http;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media;

namespace UnifyRandomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] random_arr = RandomService.GetRandomIntegers();

            BitmapPictureService.CreateBitMapFromArray(random_arr);

        }

    }
}
