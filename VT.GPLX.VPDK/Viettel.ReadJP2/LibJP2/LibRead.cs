using System;
using System.Collections.Generic;
using FreeImageAPI;
using System.Drawing;
using System.IO;

namespace Viettel.ReadJP2.LibJP2
{
    public class LibRead
    {
        public static Bitmap GetBitMap(string url)
        {
            try
            {
                if (File.Exists(url))
                {
                    FIBITMAP fib = FreeImage.LoadEx(url);
                    Bitmap bit = FreeImage.GetBitmap(fib);
                    //bit.Size = new Size(20, 20);
                    return bit;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        
    }
}
