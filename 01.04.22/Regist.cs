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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowDialog();
            this.Close();
            //записать в файл имя
        }

    }
}
