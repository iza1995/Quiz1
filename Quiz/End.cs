using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class End : Form
    {
        public End(int x, int y)
        {
            InitializeComponent();

            this.label1.Text = x.ToString() + "/" + y.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void End_Load(object sender, EventArgs e)
        {

        }
    }
}
