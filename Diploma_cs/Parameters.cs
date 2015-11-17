using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma_cs
{
    public class Parameters
    {
        public List<double[]> par;
        Form f;
        Button btn;
        TextBox tb;
        ComboBox cb;

        public Parameters()
        {
            par = new List<double[]>();

            par.Add(new double[] { 5.0, 3.0, 0.1 }); //bilateral
            par.Add(new double[] { 0.15, 0, 0 }); //low-pass
            par.Add(new double[] { 3.0, 3.0, 0 }); //median
            par.Add(new double[] { 3.0, 3.0, 0 }); //amean
            par.Add(new double[] { 3.0, 3.0, 0 }); //gmean
            par.Add(new double[] { 3.0, 3.0, 0 }); //hmean
            par.Add(new double[] { 3.0, 3.0, 1.5 }); //chmean
            par.Add(new double[] { 3.0, 3.0, 0 }); //max
            par.Add(new double[] { 3.0, 3.0, 0 }); //min
            par.Add(new double[] { 3.0, 3.0, 0 }); //midpoint
            par.Add(new double[] { 3.0, 3.0, 2.0 }); //atrimmed
            par.Add(new double[] { 0.15, 0, 0 }); //high-pass

            f = new Form();
            btn = new Button();
            tb = new TextBox();
            cb = new ComboBox();

            btn.Parent = f;
            tb.Parent = f;
            cb.Parent = f;

            tb.Top = 5;
            tb.Left = 5;
            tb.Text = par[0][0].ToString() + " " + par[0][1].ToString() + " " + par[0][2].ToString();


            btn.Left = 5;
            btn.Top = tb.Bottom + 5;
            btn.Text = "Задать";
            btn.Click += new System.EventHandler(bClicked);

            cb.Top = btn.Bottom + 5;
            cb.Left = 5;
            cb.SelectedIndexChanged += new System.EventHandler(cbChanged);
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.AddRange(new object[] {
                "Билатеральный",
                "Низких частот",
                "Медианный",
                "А-среднее",
                "Г-среднее",
                "H-mean",
                "CH-mean",
                "Максимум",
                "Минимум",
                "Средняя точка",
                "A-Trimmed",
                "Высоких частот",});
            cb.SelectedIndex = 0;
        }

        public void ChangeP()
        {
            f.ShowDialog();
        }

        void cbChanged(object sender, EventArgs e)
        {
            tb.Text = "";
            foreach (double t in par[cb.SelectedIndex])
            {
                tb.Text += t.ToString() + " ";
            }
        }

        void bClicked(object sender, EventArgs e)
        {
            string[] ps = tb.Text.Split(' ');
            double[] p = new double[ps.Length - 1];
            for (int i = 0; i < ps.Length - 1; i++ )
            {
                p[i] = double.Parse(ps[i]);
            }
            par[cb.SelectedIndex] = p;
        }
    }
}
