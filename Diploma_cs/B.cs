using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bfilter;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;

namespace Diploma_cs
{
    class B : Bilateral
    {
        public double WorkTime;
        public Image RunFilter(Image src)
        {
            filterDataContext db = new filterDataContext();
            //Bilateral Bilateral = new Bilateral();
            double[] sigma = new double[] { 3, 0.1 };
            double w = 5;
            MWNumericArray mw_sigma = new MWNumericArray(sigma);
            //MWArray Result = Bilateral.bfilter2(image, w, mw_sigma);
            //MWArray image = new MWNumericArray(src.Array.Array);
            /*
            int H = src.Height;
            int W = src.Width;

            int sq = W * H;
            */
            MWArray[] Result = bilateral(2, src.image, w, mw_sigma);
            //MWArray[] Result = bfilter2(2, src.image, w, mw_sigma);
            MWNumericArray descriptor = null;
            descriptor = (MWNumericArray)Result[0];
            double[,] result = null;
            result = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            Image res = new Image(result);
            MWNumericArray e_descriptor = null;
            e_descriptor = (MWNumericArray)Result[1];
            WorkTime = (double)e_descriptor.ToScalarDouble();
            db.add_b_res(src.Height, src.Height / src.Width, WorkTime, w, sigma[0], sigma[1]);
            Result = null;
            e_descriptor = null;
            result = null;
            mw_sigma = null;
            GC.Collect();
            return res;
        }
    }
}
