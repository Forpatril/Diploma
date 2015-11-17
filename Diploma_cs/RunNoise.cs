using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma_cs
{
    class RunNoise
    {
        public static string[] type = new string[7] { "uniform", "gaussian", "salt & pepper", "lognormal", "rayleigh", "exponential", "erlang" };
        public int id;
        public double a, b;

        public Image Do(Image src)
        {
            Noise n = new Noise();
            Image res = n.addNoise(type[id], src, a, b);
            Form1.pic pic = new Form1.pic();
            pic.id = id;
            pic.src = res.Bitmap;
            Form1.pb = pic;
            n = null;
            GC.Collect();
            return res;
            
        }

        public Image Do(Image src, int st_id)
        {
            Noise n = new Noise();
            Image res = n.addNoise(type[id], src, a, b);
            Form1.pic pic = new Form1.pic();
            pic.id = st_id;
            pic.src = res.Bitmap;
            Form1.pb = pic;
            n = null;
            GC.Collect();
            return res;

        }

        public Image Do(Image src, bool i)
        {
            Noise n = new Noise();
            Image res = n.addNoise(type[id], src, a, b);
            n = null;
            GC.Collect();
            return res;
        }
    }
}
