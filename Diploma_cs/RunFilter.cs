using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using filter;

namespace Diploma_cs
{
    class RunFilter
    {
        public Image Do(Image src, int t)
        {
            Image res = null;
            Filters f = new Filters();
            res = f.RunFilter(src, t);
            f = null;
            GC.Collect();
            return res;
        }

        public Image Do(Image src, int t, int id)
        {
            Image res = null;
            Filters f = new Filters();
            res = f.RunFilter(src, t);
            f = null;
            Form1.pic pic = new Form1.pic();
            if (t > 9)
                pic.id = id + 10;
            else
                pic.id = id;
            pic.src = res.Bitmap;
            Form1.pb = pic;
            GC.Collect();
            return res;
        }

        public Image Do(Image src, int t, int id, int st_id)
        {
            Image res = null;
            Filters f = new Filters();
            res = f.RunFilter(src, t);
            f = null;
            Form1.pic pic = new Form1.pic();
            if (t > 9)
                pic.id = id + st_id + 10;
            else
                pic.id = id + st_id;
            pic.src = res.Bitmap;
            Form1.pb = pic;
            GC.Collect();
            return res;
        }
    }
}
