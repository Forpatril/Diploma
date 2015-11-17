using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using System.Drawing;
using System.Drawing.Imaging;

namespace Diploma_cs
{
    class TestNoise
    {
        public void test(Image t)
        {
            MWNumericArray d = (MWNumericArray)t.image;
            double[,] i_d = (double[,])d.ToArray(MWArrayComponent.Real);
            Bitmap bmp = new Bitmap(t.Height, t.Width);
            for (int i = 0; i < t.Height; i++)
            {
                for (int j = 0; j < t.Width; j++)
                {
                    byte pixel = (byte)(i_d[j, i] * 255);
                    Color color = Color.FromArgb(255, pixel, pixel, pixel);
                    bmp.SetPixel(i, j, color);
                }
            }
            System.Windows.Forms.Form TestForm = new System.Windows.Forms.Form();
            TestForm.Size = new System.Drawing.Size(t.Width + 20, t.Height + 40);
            Graphics g = TestForm.CreateGraphics();
            g.DrawImage(bmp, 0, 0);
            TestForm.ShowDialog();
        }
    }
}
