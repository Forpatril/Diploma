using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFilters;
using filter;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;

namespace Diploma_cs
{
    class Filters : filterclass
    {
        public double WorkTime;
        static public string[] type = new string[12] { "bilateral", "low", "median", "amean", "gmean", "hmean", "chmean", "max", "min", "midpoint", "atrimmed", "high" };
        public Image RunFilter(Image src)
        {
            filterDataContext db = new filterDataContext();
            double[] sigma = new double[] { 3.0, 3.0 };
            MWNumericArray mw_sigma = new MWNumericArray(sigma);
            MWLogicalArray mw_print = new MWLogicalArray(Form1.print);
            MWArray[] Result = filter2(2, src.image, type[2], mw_print);//spfilt(2, src.image, "median");
            MWNumericArray descriptor = null;
            descriptor = (MWNumericArray)Result[0];
            double[,] result = null;
            result = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            Image res = new Image(result);
            MWNumericArray e_descriptor = null;
            e_descriptor = (MWNumericArray)Result[1];
            WorkTime = (double)e_descriptor.ToScalarDouble();
            //db.add_b_res(src.Height, src.Height / src.Width, WorkTime, w, sigma[0], sigma[1]);
            Result = null;
            e_descriptor = null;
            result = null;
            mw_sigma = null;
            GC.Collect();
            return res;
        }

        public Image RunFilter(Image src, int id)
        {
            filterDataContext db = new filterDataContext();
            double[] p = new double[Form1.pars.par[id].Length];
            p = Form1.pars.par[id];
            MWNumericArray parameters = new MWNumericArray(p);
            MWLogicalArray mw_print = new MWLogicalArray(Form1.print);
            MWArray[] Result = filter2(2, src.image, type[id], parameters, mw_print);
            MWNumericArray descriptor = null;
            descriptor = (MWNumericArray)Result[0];
            double[,] result = null;
            result = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            Image res = new Image(result);
            MWNumericArray e_descriptor = null;
            e_descriptor = (MWNumericArray)Result[1];
            res.Time = WorkTime = (double)e_descriptor.ToScalarDouble();
            //db.add_b_res(src.Height, src.Height / src.Width, WorkTime, w, sigma[0], sigma[1]);
            Result = null;
            e_descriptor = null;
            result = null;
            parameters = null;
            GC.Collect();
            return res;
        }
    }
}
