using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using imnoise;

namespace Diploma_cs
{
    class Noise : imnoise.Noise
    {
        public Image addNoise(string type, Image src, double a, double b)
        {
            MWLogicalArray mw_print = new MWLogicalArray(Form1.print);
            MWArray Result = noise(type, new MWNumericArray(src.Array.Array), a, b, mw_print);
            Image res = new Image((double[,])((MWNumericArray)Result).ToArray(MWArrayComponent.Real));
            MWNumericArray tmp = new MWNumericArray(res.Array.Array);
            res.image = (MWArray)tmp;
            Result = null;
            tmp = null;
            GC.Collect();
            return res;
        }
    }
}
