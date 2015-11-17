using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using filter;
using Load;
using bfilter;
using low;
using high;
using ZedGraph;
using psnr2;
using System.IO;
using System.Threading;

namespace Diploma_cs
{
    public partial class Form1 : Form
    {
        //private bool isColor = false;
        //private MWArray image = null;
        private Image image;
        bool n = true;

        List<Image> im;
        static List<PictureBox> pb_array;
        List<System.Windows.Forms.Label> lb_array;

        private int ns = 1, ft = 0;

        bool[] run;

        double[] psnr;
        public struct param
        {
            public double a, b;
            public param(double _a, double _b)
            {
                this.a = _a;
                this.b = _b;
            }
        }

        static public Parameters pars;

        static public List<param> par;

        NoiseParameters npars;

        static public int noise = 2;

        static bool pr = false;

        static filterDataContext db;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            tabControl1.SelectTab(tabPage2);
            run = new bool[] { false, false, false };
            im = new List<Image>(11);
            pb_array = new List<PictureBox>();
            pb_array.Add(pictureBox3);
            pb_array.Add(pictureBox4);
            pb_array.Add(pictureBox5);
            pb_array.Add(pictureBox6);
            pb_array.Add(pictureBox7);
            pb_array.Add(pictureBox8);
            pb_array.Add(pictureBox9);
            pb_array.Add(pictureBox11);
            pb_array.Add(pictureBox12);
            pb_array.Add(pictureBox13);
            pb_array.Add(pictureBox14);
            pb_array.Add(pictureBox15);
            pb_array.Add(pictureBox16);
            pb_array.Add(pictureBox17);
            pb_array.Add(pictureBox18);
            pb_array.Add(pictureBox19);
            pb_array.Add(pictureBox20);
            pb_array.Add(pictureBox21);
            pb_array.Add(pictureBox22);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 0;
            par = new List<param>(7);
            par.Add(new param(0, 0.055));
            par.Add(new param(0, 0.055));
            par.Add(new param(0.04, 0.04));
            par.Add(new param(0.6, 0.25));
            par.Add(new param(0, 0.055));
            par.Add(new param(12.6, 0.055));
            par.Add(new param(12.6, 3));
            pars = new Parameters();
            npars = new NoiseParameters();
            psnr = new double[11];
            lb_array = new List<System.Windows.Forms.Label>();
            lb_array.Add(label17);
            lb_array.Add(label18);
            lb_array.Add(label19);
            lb_array.Add(label20);
            lb_array.Add(label21);
            lb_array.Add(label22);
            lb_array.Add(label23);
            lb_array.Add(label24);
            lb_array.Add(label25);
            lb_array.Add(label26);
            lb_array.Add(label27);
            lb_array.Add(label28);
            lb_array.Add(label29);
            lb_array.Add(label30);
            lb_array.Add(label31);
            lb_array.Add(label32);
            lb_array.Add(label33);
            lb_array.Add(label34);
            db = new filterDataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterclass f = new filterclass();
            f.runDemo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "D:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\einstein.jpg";
            if (!checkBox1.Checked)
            {
                openFileDialog1.InitialDirectory = Application.StartupPath;
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                path = openFileDialog1.FileName;
            }
            image = new Image(path);

            if (image.Array == null)
            {
                MessageBox.Show("Цветное изображение, используйте изображение в градациях серого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            path = "";
            label1.Text = "Загружено";
            pictureBox1.Image = image.Bitmap;
            pictureBox1.Size = pictureBox1.Image.Size;

            List<int> a = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                a.Add(i);
            }
            MWNumericArray mw_a = new MWNumericArray(a.ToArray());
        }

        /*
        private Bitmap getImage(double[,] image)
        {
            int w = image.GetLength(1);
            int h = image.GetLength(0);
            Bitmap r_image = new Bitmap(w, h);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    byte pixel = (byte)(image[i, j] * 255);
                    Color color = Color.FromArgb(255, pixel, pixel, pixel);
                    r_image.SetPixel(j, i, color);
                }
            }
            return r_image;
        }

        private Bitmap getImage(double[, ,] image)
        {
            int w = image.GetLength(2);
            int h = image.GetLength(1);
            Bitmap r_image = new Bitmap(w, h);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    byte r = (byte)(image[0, i, j] * 255);
                    byte g = (byte)(image[1, i, j] * 255);
                    byte b = (byte)(image[2, i, j] * 255);
                    Color color = Color.FromArgb(255, r, g, b);
                    r_image.SetPixel(j, i, color);
                }
            }
            return r_image;
        }
        */

        private void button3_Click(object sender, EventArgs e)
        {
            B b = new B();
            Noise n = new Noise();
            Image res = n.addNoise("gaussian", image, 0, 0.055);
            pictureBox1.Image = res.Bitmap;
            Application.DoEvents();
            res = b.RunFilter(res);

            //Bilateral Bilateral = new Bilateral();
            //double[] sigma = new double[] {3, 0.1};
            //double w = 5;
            //MWNumericArray mw_sigma = new MWNumericArray(sigma);
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            ////MWArray Result = Bilateral.bfilter2(image, w, mw_sigma);
            //MWArray[] Result = Bilateral.bfilter2(2, image, w, mw_sigma);
            //stopwatch.Stop();
            //MWNumericArray descriptor = null;
            //descriptor = (MWNumericArray)Result[0];
            //MWNumericArray e_descriptor = null;
            //e_descriptor = (MWNumericArray)Result[1];
            //double Elapsed = (double)e_descriptor.ToScalarDouble();
            //Bitmap Image;
            //if (!isColor)
            //{
            //    double[,] d_descriptor = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            //    Image = getImage(d_descriptor);
            //}
            //else
            //{
            //    double[,,] d_descriptor = (double[, ,])descriptor.ToArray(MWArrayComponent.Real);
            //    Image = getImage(d_descriptor);
            //}
            //pictureBox1.Size.Height = res.Height;
            //pictureBox1.Size.Width = res.Width;

            pictureBox1.Image = res.Bitmap;
            //label1.Text = stopwatch.Elapsed.ToString();
            //label2.Text = Elapsed.ToString();
            filterDataContext db = new filterDataContext();
            label1.Text = b.WorkTime.ToString();
            db.add_b_res(res.Height, res.Height / res.Width, b.WorkTime, 5, 3, 0.1);
            //isColor = false;
            b = null;
            n = null;
            res = null;
            GC.Collect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ilpf ilpf = new ilpf();
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //MWArray Result = ilpf.low(image);
            //stopwatch.Stop();
            //MWNumericArray descriptor = null;
            //descriptor = (MWNumericArray)Result;
            //Bitmap Image;
            //double[,] d_descriptor = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            //Image = getImage(d_descriptor);

            //Graphics g = pictureBox1.CreateGraphics();
            //g.DrawImage(Image, 1, 1);
            //label1.Text = stopwatch.Elapsed.ToString();
            //isColor = false;
            //db.add_l_res(Image.Height, Image.Height / Image.Width, stopwatch.ElapsedMilliseconds, 0.15);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ihpf ihpf = new ihpf();
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //MWArray Result = ihpf.high(image);
            //stopwatch.Stop();
            //MWNumericArray descriptor = null;
            //descriptor = (MWNumericArray)Result;
            //Bitmap Image;
            //double[,] d_descriptor = (double[,])descriptor.ToArray(MWArrayComponent.Real);
            //Image = getImage(d_descriptor);

            //Graphics g = pictureBox1.CreateGraphics();
            //g.DrawImage(Image, 1, 1);
            //label1.Text = stopwatch.Elapsed.ToString();
            //isColor = false;
            //db.add_h_res(Image.Height, Image.Height / Image.Width, stopwatch.ElapsedMilliseconds, 0.15);

        }

        private void tblbilateralBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblbilateralBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.filterDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filterDataSet.tblbilateral' table. You can move, or remove it, as needed.
            this.tblbilateralTableAdapter.Fill(this.filterDataSet.tblbilateral);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "D:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\einstein.jpg";
            if (!checkBox1.Checked)
            {
                openFileDialog1.InitialDirectory = Application.StartupPath;
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                path = openFileDialog1.FileName;
            }
            image = new Image(path);

            if (image.Array == null)
            {
                MessageBox.Show("Цветное изображение, используйте изображение в градациях серого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            path = "";

            im.Clear();
            for (int i = 0; i < 7; i++)
                im.Add(null);

            pictureBox2.Image = image.Bitmap;

            backgroundWorker1.RunWorkerAsync(100);
            backgroundWorker2.RunWorkerAsync(200);
            backgroundWorker3.RunWorkerAsync(300);
            backgroundWorker4.RunWorkerAsync(400);
            backgroundWorker5.RunWorkerAsync(500);
            backgroundWorker6.RunWorkerAsync(600);
            backgroundWorker7.RunWorkerAsync(700);
            button7.Enabled = true;
        }

        public struct pic
        {
            public Bitmap src;
            public int id;
        }

        public static pic pb
        {
            set { pb_array[value.id].Image = value.src; }
        }

        public static bool print
        {
            get { return pr; }
        }

        struct lb_res
        {
            public int id;
            public string value;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;

            int id = (int)e.Argument;
            if ((id % 100) / 10 == 0)
            {
                RunNoise rn = new RunNoise();
                rn.id = (id / 100) - 1;
                rn.a = par[(id / 100) - 1].a;
                rn.b = par[(id / 100) - 1].b;
                im[(id / 100) - 1] = rn.Do(image);
            }
            else if ((id % 100) / 10 == 1)
            {
                RunFilter rf = new RunFilter();
                Image ret = rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
                psnrClass p = new psnrClass();
                MWArray ps = p.psnr(ret.image, image.image);
                psnr[(id / 100) - 1] = (double)((MWNumericArray)ps).ToScalarDouble();
                lb_res res = new lb_res();
                res.id = (id / 100) - 1;
                res.value = psnr[(id / 100) - 1].ToString("F2") + " " + ret.Time.ToString("F2");
                e.Result = res;
            }
            else if ((id % 100) / 10 == 2)
            {
                RunFilter rf = new RunFilter();
                Image ret = rf.Do(im[(id / 100) - 1], (id / 100) - 1, id % 10, 8);
                psnrClass p = new psnrClass();
                MWArray ps = p.psnr(ret.image, image.image);
                psnr[(id / 100) - 1] = (double)((MWNumericArray)ps).ToScalarDouble();
                lb_res res = new lb_res();
                res.id = (id / 100) + 6;
                res.value = psnr[(id / 100) - 1].ToString("F2") + " " + ret.Time.ToString("F2");
                //db.add_line(Filters.type[(id / 100) - 1], RunNoise.type[Form1.noise], ret.Height, ret.Width, ret.Time, psnr[(id / 100) - 1], pars.par[(id / 100) - 1][0], pars.par[(id / 100) - 1][1], pars.par[(id / 100) - 1][2]);
                e.Result = res;
            }
            else
            {
                //FillDB f = new FillDB();
                //f.Fill("C:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\Images", id % 10, worker);
                if (id % 100 < 4)
                    FillDB.Fill("C:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\Images", id % 10, worker);
                else
                    FillDB.Analyze(worker);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            /*
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;

            int id = (int)e.Argument;
            if ((id % 100) / 10 == 0)
            {
                RunNoise rn = new RunNoise();
                rn.id = (id / 100) - 1;
                rn.a = 0;
                rn.b = 0.055;
                im[(id / 100) - 1] = rn.Do(image);
            }
            else
            {
                RunFilter rf = new RunFilter();
                rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            }
            */

            DoWork(sender, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 1;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            //System.ComponentModel.BackgroundWorker worker;
            //worker = (System.ComponentModel.BackgroundWorker)sender;

            //int id = (int)e.Argument;
            //if ((id % 100) / 10 == 0)
            //{
            //    RunNoise rn = new RunNoise();
            //    rn.id = (id / 100) - 1;
            //    rn.a = 0;
            //    rn.b = 0.055;
            //    im[(id / 100) - 1] = rn.Do(image);
            //}
            //else
            //{
            //    RunFilter rf = new RunFilter();
            //    rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            //}
            DoWork(sender, e);
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar2.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 2;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            //System.ComponentModel.BackgroundWorker worker;
            //worker = (System.ComponentModel.BackgroundWorker)sender;

            //int id = (int)e.Argument;
            //if ((id % 100) / 10 == 0)
            //{
            //    RunNoise rn = new RunNoise();
            //    rn.id = (id / 100) - 1;
            //    rn.a = 0.04;
            //    rn.b = 0.04;
            //    im[(id / 100) - 1] = rn.Do(image);
            //}
            //else
            //{
            //    RunFilter rf = new RunFilter();
            //    rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            //}
            DoWork(sender, e);
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar3.Value = e.ProgressPercentage;
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 3;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            //System.ComponentModel.BackgroundWorker worker;
            //worker = (System.ComponentModel.BackgroundWorker)sender;

            //int id = (int)e.Argument;
            //if ((id % 100) / 10 == 0)
            //{
            //    RunNoise rn = new RunNoise();
            //    rn.id = (id / 100) - 1;
            //    rn.a = 0.6;
            //    rn.b = 0.25;
            //    im[(id / 100) - 1] = rn.Do(image);
            //}
            //else
            //{
            //    RunFilter rf = new RunFilter();
            //    rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            //}
            DoWork(sender, e);
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar4.Value = e.ProgressPercentage;
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 4;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            backgroundWorker1.RunWorkerAsync(110 + comboBox1.SelectedIndex);
            backgroundWorker2.RunWorkerAsync(210 + comboBox1.SelectedIndex);
            backgroundWorker3.RunWorkerAsync(310 + comboBox1.SelectedIndex);
            backgroundWorker4.RunWorkerAsync(410 + comboBox1.SelectedIndex);
            backgroundWorker5.RunWorkerAsync(510 + comboBox1.SelectedIndex);
            backgroundWorker6.RunWorkerAsync(610 + comboBox1.SelectedIndex);
            backgroundWorker7.RunWorkerAsync(710 + comboBox1.SelectedIndex);
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            //System.ComponentModel.BackgroundWorker worker;
            //worker = (System.ComponentModel.BackgroundWorker)sender;

            //int id = (int)e.Argument;
            //if ((id % 100) / 10 == 0)
            //{
            //    RunNoise rn = new RunNoise();
            //    rn.id = (id / 100) - 1;
            //    rn.a = 0;
            //    rn.b = 0.055;
            //    im[(id / 100) - 1] = rn.Do(image);
            //}
            //else
            //{
            //    RunFilter rf = new RunFilter();
            //    rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            //}
            DoWork(sender, e);
        }

        private void backgroundWorker5_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 5;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            //System.ComponentModel.BackgroundWorker worker;
            //worker = (System.ComponentModel.BackgroundWorker)sender;

            //int id = (int)e.Argument;
            //if ((id % 100) / 10 == 0)
            //{
            //    RunNoise rn = new RunNoise();
            //    rn.id = (id / 100) - 1;
            //    rn.a = 0.4;
            //    rn.b = 0.055;
            //    im[(id / 100) - 1] = rn.Do(image);
            //}
            //else
            //{
            //    RunFilter rf = new RunFilter();
            //    rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            //}
            DoWork(sender, e);
        }

        private void backgroundWorker6_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 6;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            // This event handler is where the actual work is done.
            // This method runs on the background thread.

            // Get the BackgroundWorker object that raised this event.
            //System.ComponentModel.BackgroundWorker worker;
            //worker = (System.ComponentModel.BackgroundWorker)sender;

            //int id = (int)e.Argument;
            //if ((id % 100) / 10 == 0)
            //{
            //    RunNoise rn = new RunNoise();
            //    rn.id = (id / 100) - 1;
            //    rn.a = 0.6;
            //    rn.b = 2;
            //    im[(id / 100) - 1] = rn.Do(image);
            //}
            //else
            //{
            //    RunFilter rf = new RunFilter();
            //    rf.Do(im[(id / 100) - 1], id % 10, (id / 100) - 1);
            //}
            DoWork(sender, e);
        }

        private void backgroundWorker7_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 7;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = "D:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\einstein.jpg";
            if (!checkBox1.Checked)
            {
                openFileDialog1.InitialDirectory = Application.StartupPath;
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                path = openFileDialog1.FileName;
            }
            image = new Image(path);

            if (image.Array == null)
            {
                MessageBox.Show("Цветное изображение, используйте изображение в градациях серого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            path = "";

            pictureBox10.Image = image.Bitmap;
            RunNoise ns = new RunNoise();
            noise = ns.id = comboBox2.SelectedIndex;
            ns.a = par[comboBox2.SelectedIndex].a;
            ns.b = par[comboBox2.SelectedIndex].b;
            Image res = ns.Do(image, 7);

            psnrClass p = new psnrClass();
            MWArray ps = p.psnr(res.image, image.image);
            double pnr = ((double)((MWNumericArray)ps).ToScalarDouble());
            label36.Text = pnr.ToString();

            label3.Text = "";
            im.Clear();
            for (int i = 0; i < 11; i++)
                im.Add(res);
            backgroundWorker1.RunWorkerAsync(120);
            backgroundWorker2.RunWorkerAsync(221);
            backgroundWorker3.RunWorkerAsync(322);
            backgroundWorker4.RunWorkerAsync(423);
            backgroundWorker5.RunWorkerAsync(524);
            backgroundWorker6.RunWorkerAsync(625);
            backgroundWorker7.RunWorkerAsync(726);
            backgroundWorker8.RunWorkerAsync(827);
            backgroundWorker9.RunWorkerAsync(928);
            backgroundWorker10.RunWorkerAsync(1029);
            backgroundWorker11.RunWorkerAsync(1120);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Size sz = zedGraphControl1.Size;
            Graph g = new Graph();
            zedGraphControl1.GraphPane = g.Draw(zedGraphControl1.GraphPane, comboBox3.SelectedIndex);

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar2.Visible = true;
            progressBar3.Visible = true;
            backgroundWorker1.RunWorkerAsync(130);
            backgroundWorker2.RunWorkerAsync(231);
            backgroundWorker3.RunWorkerAsync(332);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Form dlg = new Form();
            dlg.AutoScroll = true;
            PictureBox pb = new PictureBox();
            pb.Parent = dlg;
            pb.Size = ((PictureBox)sender).Image.Size;
            pb.Location = new Point(0, 0);
            pb.Image = ((PictureBox)sender).Image;
            pb.MouseClick += new MouseEventHandler(rMouseClick);
            dlg.WindowState = FormWindowState.Maximized;
            dlg.ShowDialog();
            dlg = null;
            pb = null;
            GC.Collect();
        }

        private void rMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox p;
                p = (PictureBox)sender;
                p.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //to do work here
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pars.ChangeP();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts;
            ts = (ToolStripMenuItem)sender;
            ContextMenuStrip s = (ContextMenuStrip)ts.Owner;
            PictureBox p = (PictureBox)s.SourceControl;
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Images|*.jpg";
            sd.AddExtension = true;
            sd.InitialDirectory = Application.StartupPath;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                p.Image.Save(sd.FileName);
            }
        }

        private void шумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            npars.ChangeP();
        }

        private void backgroundWorker8_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 8;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker9_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += 9;
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker10_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += "A";
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker11_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += "B";
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void backgroundWorker12_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes.
            // This method runs on the main thread.
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
                MessageBox.Show("Word counting canceled.");
            else
            {
                //MessageBox.Show("Finished counting words.");
                label3.Text += "C";
                if (e.Result != null)
                {
                    lb_array[((lb_res)e.Result).id].Text = ((lb_res)e.Result).value.ToString();
                }
            }
        }

        private void выводToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            pr = this.выводToolStripMenuItem.Checked;
        }

        private void выборИзображенияToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = !выборИзображенияToolStripMenuItem.Checked;
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = label3.Text;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            progressBar4.Visible = true;
            backgroundWorker4.RunWorkerAsync(431);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                toolStripMenuItem2.Enabled = true;
            else
                toolStripMenuItem2.Enabled = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int c = Directory.GetDirectories(Application.StartupPath, comboBox2.Text + "*").Length;
            string Dir = comboBox2.Text + c.ToString("D3");
            Directory.CreateDirectory(Dir);
            string path = Dir + "\\01.orig.jpg";
            pictureBox10.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            path = Dir + "\\02.noise.jpg";
            pictureBox11.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            FileInfo f = new FileInfo(Dir + "\\info.txt");
            StreamWriter s = f.CreateText();
            s.WriteLine("noise " + label36.Text);
            for (int i = 8; i < pb_array.Count; i++)
            {
                path = Dir + "\\" + (i - 5).ToString("D2") + "." + Filters.type[i - 8] + ".jpg";
                pb_array[i].Image.Save(path);
                s.WriteLine(Filters.type[i - 8] + " " + lb_array[i - 1].Text);
            }
            s.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int n, f;
            string path;
            Image wrk;
            if (checkBox2.Checked)
            {
                n = 2;
                f = 2;
                path = "D:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\Images\\0dba4c83f4c7f864d9b7993545cfc.jpg";
            }
            else
            {
                n = ns;
                f = ft;
                if (checkBox1.Checked)
                    path = "D:\\Users\\Forpatril\\Documents\\Visual Studio 2010\\Projects\\Diploma_cs\\einstein.jpg";
                else
                {
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                    path = openFileDialog1.FileName;
                }
            }
            wrk = new Image(path);

            if (wrk.Array == null)
            {
                MessageBox.Show("Цветное изображение, используйте изображение в градациях серого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            path = "";

            pictureBox23.Image = wrk.Bitmap;
            RunNoise nois = new RunNoise();
            nois.a = par[n].a;
            nois.b = par[n].b;
            nois.id = n;
            wrk = nois.Do(wrk, true);
            pictureBox24.Image = wrk.Bitmap;
            RunFilter filt = new RunFilter();
            wrk = filt.Do(wrk, f);
            pictureBox25.Image = wrk.Bitmap;
            nois = null;
            wrk = null;
            filt = null;
            GC.Collect();
        }

        private void filterClick(object sender, EventArgs e)
        {
            ft = (int)((ToolStripItem)sender).Tag;
        }

        private void noiseClick(object sender, EventArgs e)
        {
            ns = (int)((ToolStripItem)sender).Tag;
        }
    }
}
