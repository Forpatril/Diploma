using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diploma_cs
{
    class NoiseParameters
    {
        Form f;
        Button btn;
        TextBox tb;
        ComboBox cb;

        public NoiseParameters()
        {
            f = new Form();
            btn = new Button();
            tb = new TextBox();
            cb = new ComboBox();

            btn.Parent = f;
            tb.Parent = f;
            cb.Parent = f;

            tb.Top = 5;
            tb.Left = 5;
            tb.Text = Form1.par[0].a.ToString() + " " + Form1.par[0].b.ToString();


            btn.Left = 5;
            btn.Top = tb.Bottom + 5;
            btn.Text = "Задать";
            btn.Click += new System.EventHandler(bClicked);

            cb.Top = btn.Bottom + 5;
            cb.Left = 5;
            cb.SelectedIndexChanged += new System.EventHandler(cbChanged);
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.AddRange(new object[] {
                "Равномерный",
                "Гауссов",
                "Соль-перец",
                "Логнормальный",
                "Релеевский",
                "Экспоненциальный",
                "Эрланга"});
            cb.SelectedIndex = 0;
        }

        public void ChangeP()
        {
            f.ShowDialog();
        }

        void cbChanged(object sender, EventArgs e)
        {
            tb.Text = "";
            tb.Text = Form1.par[cb.SelectedIndex].a.ToString() + " " + Form1.par[cb.SelectedIndex].b.ToString();
        }

        void bClicked(object sender, EventArgs e)
        {
            string[] ps = tb.Text.Split(' ');
            Form1.param p = new Form1.param();
            p.a = double.Parse(ps[0]);
            p.b = double.Parse(ps[1]);
            Form1.par[cb.SelectedIndex] = p;
        }
    }
}
