using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using low;

namespace Diploma_cs
{
    class L : ilpf
    {
        public double WorkTime;
        public Image RunFilter(Image src)
        {
            filterDataContext db = new filterDataContext();
            //Bilateral Bilateral = new Bilateral();
            //double[] sigma = new double[] { 3, 0.1 };
            //double w = 5;
            //MWNumericArray mw_sigma = new MWNumericArray(sigma);
            //MWArray Result = Bilateral.bfilter2(image, w, mw_sigma);
            //MWNumericArray image = new MWNumericArray(src.Array.Array);
            MWArray[] Result = low(2, src.image);//Bilateral.bfilter2(2, image, w, mw_sigma);
            Image res = new Image((double[,])((MWNumericArray)Result[0]).ToArray(MWArrayComponent.Real));
            MWNumericArray e_descriptor = null;
            e_descriptor = (MWNumericArray)Result[1];
            WorkTime = (double)e_descriptor.ToScalarDouble();
            db.add_l_res(src.Height, src.Height / src.Width, WorkTime, 0.15);
            Result = null;
            e_descriptor = null;
            GC.Collect();
            return res;
            /*
            ihpf ihpf = new ihpf();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MWArray Result = ihpf.high(image);
            stopwatch.Stop();
            MWNumericArray descriptor = null;
            descriptor = (MWNumericArray)Result;
            Bitmap Image;
            double[,] d_descriptor = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            Image = getImage(d_descriptor);

            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(Image, 1, 1);
            label1.Text = stopwatch.Elapsed.ToString();
            isColor = false;
            db.add_h_res(Image.Height, Image.Height / Image.Width, stopwatch.ElapsedMilliseconds, 0.15);
             */
        }
    }
}
