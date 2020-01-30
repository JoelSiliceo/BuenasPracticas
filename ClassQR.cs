using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ZXing;
using ZXing.Presentation;
using ZXing.Rendering;

namespace Project1
{
    class ClassQR
    {

        public static void Main5(string[] args)
        {
            string QCText = "Código de ejemplo";
                       
            //BarcodeWriter qCwriter = new BarcodeWriter();
            //qCwriter.Format = BarcodeFormat.QR_CODE;
            //var result = QCwriter.Write(QCText);
            //string path = ("C:\\Users\\joel.siliceo\\Desktop\\MyQRImage.jpg");
            //var barcodeBitmap = new Bitmap(result);

            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (FileStream fs = new FileStream(path,
            //       FileMode.Create, FileAccess.ReadWrite))
            //    {
            //        barcodeBitmap.Save(memory, ImageFormat.Jpeg);
            //        byte[] bytes = memory.ToArray();
            //        fs.Write(bytes, 0, bytes.Length);
            //    }
            //}

        }
    }
}
