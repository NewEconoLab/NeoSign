using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;

namespace NeoSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Directory.GetCurrentDirectory() + "\\abc.bmp");

            //**********CoreCompat.System.Drawing************

            int width = 300;
            int height = 150;

            //System.Drawing.Bitmap addBitmap = new Bitmap(StringFileName);
            Image MyImage = new System.Drawing.Bitmap(width, height);//申请位图对象
            Graphics g = Graphics.FromImage(MyImage);
            System.Drawing.Color C = System.Drawing.Color.FromArgb(255, 255, 255);
            g.Clear(C);

            //g.DrawImage(addBitmap, 0, 0, addBitmap.Width, addBitmap.Height);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;


            //int x1 = 11;
            //int y1 = 50;
            //int x2 = 30;
            //int y2 = 100;
            ////画线
            //g.DrawLine(Pens.Green, x1, y1, x2, y2);
            //画一个象素的点
            //MyBitmap.SetPixel(x, y, Color.White);

            Brush brush = new SolidBrush(Color.Black);
            Font font = new Font("宋体", 25, FontStyle.Bold);
            g.DrawString("Hello World!", font, brush, 20, 20);
            g.DrawString("你好，世界!", font, brush, 20, 50);
            brush.Dispose();
            font.Dispose();

            /* g.DrawImage(MyImage, 0, 0, h, w);*/ //pictureBox1在(0,0)到(h,w)范围画点
                                                   //pictureBox1.Image = MyImage;     //这个图片贴到pictureBox1控件上
            MyImage.Save(Directory.GetCurrentDirectory() + "\\abc.jpg");

            //**********CoreCompat.System.Drawing************
        }
    }
}
