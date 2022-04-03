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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            Game Game = new Game();
            Game.ShowDialog();
            this.Close();
        }
    }
}
