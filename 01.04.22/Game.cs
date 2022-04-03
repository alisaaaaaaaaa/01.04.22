using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._04._22
{
    public partial class Game : Form
    {
        int startvalue = 0;
        int[,] map = new int[3, 3];
        
        public Game()
        {
            InitializeComponent();
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
                (sender as Timer).Stop();
                (sender as Timer).Dispose();
                //скример
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            startvalue = 60;
            timer.Start();
        }
        private static void Picture()
        {
        }
    }
}
