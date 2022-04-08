using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace _01._04._22
{
    public partial class Game : Form
    {
        int startvalue = 0;
        int[,] map = new int[3, 3];
        PictureBox[,] Boxes = new PictureBox[3, 3];

        public Game()
        {
            InitializeComponent();
            InitwthHide();

            Boxes[0, 0] = pictureBox1;
            Boxes[0, 1] = pictureBox2;
            Boxes[0, 2] = pictureBox3;
            Boxes[1, 0] = pictureBox4;
            Boxes[1, 1] = pictureBox5;
            Boxes[1, 2] = pictureBox6;
            Boxes[2, 0] = pictureBox7;
            Boxes[2, 1] = pictureBox8;
            Boxes[2, 2] = pictureBox9;
        }
        private string strTime(int time)
        {
            int hours = (time - (time % (60 * 60))) / (60 * 60);
            int minutes = (time - time % 60) / 60 - hours * 60;
            int seconds = time - hours * 60 * 60 - minutes * 60;
            return String.Format("{0:00},{1:00},{2:00}", hours, minutes, seconds);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(startvalue!=0)
            {
                timerlab.Text = strTime(startvalue);
                startvalue--;
            }
            else
            {
                (sender as System.Windows.Forms.Timer).Stop();
                (sender as System.Windows.Forms.Timer).Dispose();
                //скример
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            startvalue = 60;
            timer.Start();
        }
        public void InitwthHide()
        {
            this.Clear();
            this.Generate();
            this.Picture();
            this.Hide();
        }
        private void Clear()
        {
            for(int i = 0; i< 3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    map[i, j] = 0;
                }
            }
        }
        private void Generate()
        {
            Random rnd = new Random();
            for (int i = 0;i<1;i++)
            {
                int j = rnd.Next(3);
                map[i, j] = 1;
            }
        }
        private void Picture()
        {
            Boxes[0, 0] = pictureBox1;
            Boxes[0, 1] = pictureBox2;
            Boxes[0, 2] = pictureBox3;
            Boxes[1, 0] = pictureBox4;
            Boxes[1, 1] = pictureBox5;
            Boxes[1, 2] = pictureBox6;
            Boxes[2, 0] = pictureBox7;
            Boxes[2, 1] = pictureBox8;
            Boxes[2, 2] = pictureBox9;
            for (int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    if (map[i,j] != 0)
                    {
                        Boxes[i, j].Image = Image.FromFile("pic.jpg");
                    }
                }
            }
        }

        private void Hide()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Boxes[i, j].Image != null)
                    {
                        Boxes[i, j].Image = Image.FromFile("back.jpg");
                    }
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ShowPic(pictureBox1, timer1);
            }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                ShowPic(pictureBox2, timer2);
            }
        }
 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                ShowPic(pictureBox3, timer3);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
            {
                ShowPic(pictureBox4, timer4);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                ShowPic(pictureBox5, timer5);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != null)
            {
                ShowPic(pictureBox6, timer6);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != null)
            {
                ShowPic(pictureBox7, timer7);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image != null)
            {
                ShowPic(pictureBox8, timer8);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image != null)
            {
                ShowPic(pictureBox9, timer9);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            timer1.Stop();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            timer2.Stop();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
            timer3.Stop();
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
            timer4.Stop();
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox5.Image = null;
            timer5.Stop();
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox6.Image = null;
            timer6.Stop();
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox7.Image = null;
            timer7.Stop();
        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox8.Image = null;
            timer8.Stop();
        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox9.Image = null;
            timer9.Stop();
        }
        private void ShowPic(PictureBox pictureBox, System.Windows.Forms.Timer tm)
        {
            pictureBox.Image = Image.FromFile("pic.jpg");
            tm.Interval = 3000;
            tm.Start();
        }
    }
}
