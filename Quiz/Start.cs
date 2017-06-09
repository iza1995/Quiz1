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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void koniec()
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.ShowDialog();
            this.Close();
            this.Dispose();

        }
    }
}
