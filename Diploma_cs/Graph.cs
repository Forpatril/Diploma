using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;

namespace Diploma_cs
{
    class Graph
    {
        private string[] type = new string[12] { "bilateral", "low", "median", "amean", "gmean", "hmean", "chmean", "max", "min", "midpoint", "atrimmed", "high" };
        public GraphPane Draw(GraphPane pane, int id)
        {
            filterDataContext db = new filterDataContext();

            double t_max = (double)(from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a.p_time).Max();
            double t_min = (double)(from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a.p_time).Min();
            double p_max = (double)(from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a.psnr).Max();
            double p_min = (double)(from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a.psnr).Min();
            double w_max = (double)(from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a.p1).Max();
            double w_min = (double)(from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a.p1).Min();

            pane.Title.Text = "Анализ продолжительности вычислений";
            pane.CurveList.Clear();
            pane.YAxis.Scale.Min = p_min;
            pane.YAxis.Scale.Max = p_max;
            pane.YAxis.Title.Text = "PSNR";
            pane.XAxis.Title.Text = "Время обработки";
            pane.XAxis.Scale.Min = t_min;
            pane.XAxis.Scale.Max = t_max;
            pane.Y2Axis.Scale.Min = w_min;
            pane.Y2Axis.Scale.Max = w_max;
            pane.Y2Axis.Title.Text = "Размер окна фильтра";

            PointPairList List1 = new PointPairList(); 
            PointPairList List2 = new PointPairList();

            var query = from a in db.Datas where (a.ftype == type[id]) && (a.ftype == "gaussian") select a;
            foreach (var test in query)
            {
                List1.Add((double)test.p_time, (double)test.psnr);
                List2.Add((double)test.p_time, (double)test.p1);
            }
            LineItem Curve1 = pane.AddCurve("", List1, Color.Blue, SymbolType.None);

            LineItem Curve2 = pane.AddCurve("", List2, Color.Blue, SymbolType.None);

            return pane;
        }
    }
}
