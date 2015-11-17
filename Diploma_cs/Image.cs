using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using Load;
using System.IO;

namespace Diploma_cs
{
    class Image
    {
        public Bitmap Bitmap;
        public ImageArray Array;
        public int Height, Width;
        public MWArray image;
        public double Time;

        public Image(string path)
        {
            MWNumericArray descriptor = null;
            MWCharArray mw_path;
            try
            {
                mw_path = new MWCharArray(path);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return;
            }
            
            Loader Loader = new Loader();
            image = Loader.loadimage(mw_path);
            descriptor = (MWNumericArray)image;
            try
            {
                Array = new ImageArray((double[,])descriptor.ToArray(MWArrayComponent.Real));
            }
            catch (InvalidCastException exc)
            {
                descriptor = null;
                mw_path = null;
                Loader = null;
                GC.Collect();
                return;
            }

            Height = Array.Array.GetLength(0);
            Width = Array.Array.GetLength(1);
            GetBitmap();

            descriptor = null;
            mw_path = null;
            Loader = null;
            GC.Collect();
        }

        private string GetRandomName()
        {
            Random tr = new Random((int)DateTime.Now.Ticks);
            char[] letters = "qwertyuiopasdfghjklzxcvbnm0123456789".ToCharArray();
            string s = "";
            for (int i = 0; i < 20; i++)
            {
                s += letters[tr.Next(letters.Length)].ToString();
            }
            return s;
        }

        public Image(double[,] values)
        {
            Array = new ImageArray(values);
            Height = Array.Array.GetLength(0);
            Width = Array.Array.GetLength(1);
            GetBitmap();
            
            /*
            string tp = "C:\\" + GetRandomName()+".bmp";

            Bitmap.Save(tp,);
            Loader tmp = new Loader();
            image = tmp.loadimage(new MWCharArray(tp));
            tmp.Dispose();
            File.Delete(tp);
            */
            MWNumericArray tmp = new MWNumericArray(values);
            image = (MWArray)tmp;

            tmp = null;
            GC.Collect();
        }

        private void GetBitmap()
        {
            Bitmap = new Bitmap(Width, Height);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    /*if (Array.Array[i, j] > 1)
                    {
                        Array.Array[i, j] /= 2;
                    }*/
                    byte pixel = (byte)(Array.Array[i, j] * 255.0);
                    Color color = Color.FromArgb(255, pixel, pixel, pixel);
                    Bitmap.SetPixel(j, i, color);
                }
            }
            GC.Collect();
        }
    }
}
