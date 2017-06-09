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


    public partial class Form1 : Form
    {
        private const int liczbaPytan = 20;
        private string[] pytania = new string[liczbaPytan];
        private string[] odpowiedziA = new string[liczbaPytan];
        private string[] odpowiedziB = new string[liczbaPytan];
        private string[] odpowiedziC = new string[liczbaPytan];
        private string[] odpowiedziD = new string[liczbaPytan];
        private string[] poprawnaOdpowiedz = new string[liczbaPytan];
        private string[] obraz = new string[liczbaPytan];


        public void uzupelnij()
        {
            for (int i = 0; i < liczbaPytan; i++)
            {
                pytania[i] = "pytanie pytanie pytanie pytanie pytanie" + i + "\n" + "pytanie pytanie pytanie pytanie pytanie" + "\n" + "pytanie pytanie pytanie pytanie pytanie";
                odpowiedziA[i] = "Odpowiedz A dla pytania numer numernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumer " + i;
                odpowiedziB[i] = "Odpowiedz B dla pytania numer numernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumer " + i;
                odpowiedziC[i] = "Odpowiedz C dla pytania numer numernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumer " + i;
                odpowiedziD[i] = "Odpowiedz D dla pytania numer numernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumernumer " + i;
                poprawnaOdpowiedz[i] = "B";
                if (i % 2 == 0)
                {
                    obraz[i] = "test1.png";
                    poprawnaOdpowiedz[i] = "B";
                }
                else
                {
                    obraz[i] = "01.png";
                    poprawnaOdpowiedz[i] = "C";
                }

            }

            label1.Text = pytania[1];
            button1.Text = odpowiedziA[1];
            button2.Text = odpowiedziB[1];
            button3.Text = odpowiedziC[1];
            button4.Text = odpowiedziD[1];
            pictureBox1.Image = new Bitmap(@"C:\Users\Konto\Desktop\Quiz\Quiz\Quiz\" + obraz[1]);
        }

        public Form1()
        {
            InitializeComponent();
            uzupelnij();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    
    }
}
