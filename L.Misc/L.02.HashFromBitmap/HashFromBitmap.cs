using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

using Aurigma.GraphicsMill;

class HashFromBitmapSample
{
    static string GetMD5Hash(Bitmap bitmap)
    {
        int scanlineByteWidth = bitmap.Width * bitmap.PixelFormat.Size / 8;

        using (var md5 = MD5.Create())
        {
            unsafe
            {
                byte* pScanline = (byte*)bitmap.Scan0.ToPointer();
                var buffer = new byte[scanlineByteWidth];

                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Marshal.Copy((IntPtr)pScanline, buffer, 0, scanlineByteWidth);                    

                    md5.TransformBlock(buffer, 0, scanlineByteWidth, buffer, 0);

                    pScanline += bitmap.Stride;
                }

                md5.TransformFinalBlock(new byte[0], 0, 0);
            }

            return String.Concat(Array.ConvertAll(md5.Hash, x => x.ToString("X2"))); 
        }
    }

    static void Main(string[] args)
    {
        using (var bitmap = new Bitmap("../../../../_Input/Chicago.jpg"))
        {
            if (bitmap.PixelFormat.IsIndexed)
                bitmap.ColorManagement.Convert(PixelFormat.Format32bppArgb);

            Console.WriteLine("MD5: {0}", GetMD5Hash(bitmap));
        }
    }
}
