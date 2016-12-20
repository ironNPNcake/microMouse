using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        //69 64
        Bitmap mapa;
        Point punkt,prevPoint;
        Bitmap original;
        public Form1()
        {
            InitializeComponent();
            mapa = new Bitmap("mapa.bmp");
            original = new Bitmap("mapa.bmp");
            pictureBox1.Image = original;
            punkt = new Point(91, 61);
            prevPoint = new Point(0, 0);

        }
        private void narysuj_cos()
        {
            mapa.SetPixel(punkt.X, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X + 1, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X + 2, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X + 3, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X - 1, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X - 2, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X - 3, punkt.Y, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y + 1, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y + 2, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y + 3, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y - 1, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y - 2, Color.Red);
            mapa.SetPixel(punkt.X, punkt.Y - 3, Color.Red);

            //mapa.SetPixel(punkt.X + 5, punkt.Y, Color.Red);
            pictureBox1.Image = mapa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            narysuj_cos();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mapa = original.Clone(new Rectangle(0, 0, 250, 250), original.PixelFormat);

            if (mapa.GetPixel(punkt.X + 1 , punkt.Y).R == 0&&prevPoint.X!=punkt.X+1)
            {   //1
                //  mapa = original
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
              punkt.X = punkt.X + 1 ;
               // MessageBox.Show("ASDasdasd");
            }
            else if (mapa.GetPixel(punkt.X + 1, punkt.Y + 1).R == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y + 1).G == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y + 1).B == 0 && prevPoint.X != punkt.X+1&&prevPoint.Y!=punkt.Y+1)
            {   //2
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                //mapa = original;
                punkt.X = punkt.X + 1;
                punkt.Y = punkt.Y + 1;
            }
            else if (mapa.GetPixel(punkt.X, punkt.Y + 1).R == 0 && mapa.GetPixel(punkt.X, punkt.Y + 1).G == 0 && mapa.GetPixel(punkt.X, punkt.Y + 1).B == 0 && prevPoint.Y != punkt.Y+1)
            {   //3
                //  mapa = original;
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                punkt.X = punkt.X;
                punkt.Y = punkt.Y + 1;
            }
            else if (mapa.GetPixel(punkt.X - 1, punkt.Y + 1).R == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y + 1).G == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y + 1).B == 0 && prevPoint.X != punkt.X-1 && prevPoint.Y != punkt.Y+1)
            {   //4
                //  mapa = original;
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                punkt.X = punkt.X - 1;
                punkt.Y = punkt.Y + 1;
            }
            else if (mapa.GetPixel(punkt.X - 1, punkt.Y).R == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y).G == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y).B == 0 && prevPoint.X != punkt.X -1)
            {   //5
                //   mapa = original;
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                punkt.X = punkt.X - 1;
                punkt.Y = punkt.Y;
            }
            else if (mapa.GetPixel(punkt.X - 1, punkt.Y - 1).R == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y - 1).G == 0 && mapa.GetPixel(punkt.X - 1, punkt.Y - 1).B == 0 && prevPoint.X != punkt.X-1 && prevPoint.Y != punkt.Y-1)
            {   //6
                //  mapa = original;
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                punkt.X = punkt.X - 1;
                punkt.Y = punkt.Y - 1;
            }
            else if (mapa.GetPixel(punkt.X, punkt.Y - 1).R == 0 && mapa.GetPixel(punkt.X, punkt.Y - 1).B == 0 && mapa.GetPixel(punkt.X, punkt.Y - 1).G == 0 && prevPoint.Y != punkt.Y-1)
            {   //7
                //  mapa = original;
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                punkt.X = punkt.X;
                punkt.Y = punkt.Y - 1;
            }
            else if (mapa.GetPixel(punkt.X + 1, punkt.Y - 1).R == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y - 1).G == 0 && mapa.GetPixel(punkt.X + 1, punkt.Y - 1).B == 0 && prevPoint.X != punkt.X+1 && prevPoint.Y != punkt.Y-1)
            {   //8
                //    mapa = original;
                prevPoint.X = punkt.X;
                prevPoint.Y = punkt.Y;
                punkt.X = punkt.X + 1;
                punkt.Y = punkt.Y - 1;
            }
            //else MessageBox.Show("asd");
          //  MessageBox.Show("hello");
            narysuj_cos();
          /*  mapa = original;
            pictureBox1.Image = mapa;
            Color pixelcolor = mapa.GetPixel(0, 0);
            MessageBox.Show(pixelcolor.ToString());
           /* if (mapa.GetPixel(0, 0).R == 255&&)
                MessageBox.Show("hello");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            punkt.X = Convert.ToInt16(textBox1.Text);
            punkt.Y = Convert.ToInt16(textBox2.Text );
            label1.Text = mapa.GetPixel(punkt.X, punkt.Y).R + " "+mapa.GetPixel(punkt.X, punkt.Y).G + " "+mapa.GetPixel(punkt.X, punkt.Y).B + " ";
        }
    }
}