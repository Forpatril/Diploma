using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using psnr2;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using filter;

namespace Diploma_cs
{
    class FillDB
    {
        public static void Fill(string path, int id, System.ComponentModel.BackgroundWorker worker)
        {
            int i = 0;
            foreach (string file in Directory.GetFiles(path, "*.jpg"))
            {
                filterDataContext db = new filterDataContext();
                Image img = new Image(file);
                Noise n = new Noise();
                img = n.addNoise("gaussian", img, 0, 0.055);
                RunFilter rf = new RunFilter();
                Image ret = rf.Do(img, id);
                psnrClass ps = new psnrClass();
                double psnr = (double)((MWNumericArray)ps.psnr(ret.image, img.image)).ToScalarDouble();
                db.add_line(Filters.type[id],"gaussian",img.Height,img.Width,ret.Time,psnr,Form1.pars.par[id][0],Form1.pars.par[id][1],Form1.pars.par[id][2]);
                worker.ReportProgress(i++);
            }
        }

        public static void Analyze(System.ComponentModel.BackgroundWorker worker)
        {
            int i = 0;
            foreach (string file in Directory.GetFiles("C:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\Images", "*.jpg"))
            {
                Image img = new Image(file);
                for (int w = 2; w < 35; w++)
                    for (int sig = 1; sig < w / 2; sig++)
                    {
                        filterclass fc = new filterclass();
                        Noise n = new Noise();
                        Image img_n = n.addNoise("gaussian", img, 0, 0.055);
                        double[] p = new double[] {w, sig, 0.2};
                        MWNumericArray parameters = new MWNumericArray(p);
                        MWLogicalArray mw_print = new MWLogicalArray(Form1.print);
                        MWArray[] Result = fc.filter2(2, img_n.image, "bilateral", parameters, mw_print);
                        MWNumericArray descriptor = null;
                        descriptor = (MWNumericArray)Result[0];
                        double[,] result = null;
                        result = (double[,])descriptor.ToArray(MWArrayComponent.Real);
                        Image ret = new Image(result);
                        MWNumericArray e_descriptor = null;
                        e_descriptor = (MWNumericArray)Result[1];
                        ret.Time = (double)e_descriptor.ToScalarDouble();

                        filterDataContext db = new filterDataContext();
                        psnrClass ps = new psnrClass();
                        double psnr = (double)((MWNumericArray)ps.psnr(ret.image, img.image)).ToScalarDouble();
                        db.add_line("bilateral", "gaussian", img.Height, img.Width, ret.Time, psnr, p[0], p[1], p[2]);


                        Result = null;
                        e_descriptor = null;
                        result = null;
                        parameters = null;
                        img_n = null;
                        n = null;
                        descriptor = null;
                        ret = null;
                        ps = null;
                        fc = null;
                        GC.Collect();
                    }
                worker.ReportProgress(i++);
                img = null;
                GC.Collect();
            }
        }
    }
}
