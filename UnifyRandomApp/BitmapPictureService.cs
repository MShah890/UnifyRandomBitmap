using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UnifyRandomApp
{
    public static class BitmapPictureService
    {
        public static byte[] image_buffer = new byte[65536]; //128 * 128 * 4 bytes

        public static void CreateBitMapFromArray(byte[] random_arr)
        {
            Random rnd = new Random();

            //128 x 128 image
            for (int y = 0; y < 128; y++)
            {
                for (int x = 0; x < 128; x++)
                {
                    byte val = (byte)x;

                    //Selecting Randomly from the 100 random numbers in random_arr obtained from API to put in place for R, G and B parameters

                    PlotPixel(x, y, random_arr[rnd.Next(0, 100)], random_arr[rnd.Next(0, 100)], random_arr[rnd.Next(0, 100)]);
                }
            }

            unsafe
            {
                fixed (byte* ptr = image_buffer)
                {
                    using (Bitmap image = new Bitmap(128, 128, 128 * 4,
                       System.Drawing.Imaging.PixelFormat.Format32bppRgb, new IntPtr(ptr)))
                    {
                        image.Save(@"../../../images/random_bitmap_image.png"); //Saving image as png in images folder
                    }
                }
            }
        }

        private static void PlotPixel(int x, int y, byte red_val,
 byte green_val, byte blue_val)
        {
            int offset = ((128 * 4) * y) + (x * 4);
            image_buffer[offset] = red_val;
            image_buffer[offset + 1] = green_val;
            image_buffer[offset + 2] = blue_val;
            // Fixed alpha value (No transparency)
            image_buffer[offset + 3] = 255;
        }
    }
}
