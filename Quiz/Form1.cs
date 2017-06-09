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
        private const int liczbaPytan = 6;
        private string[] pytania = new string[liczbaPytan];
        private string[] odpowiedziA = new string[liczbaPytan];
        private string[] odpowiedziB = new string[liczbaPytan];
        private string[] odpowiedziC = new string[liczbaPytan];
        private string[] odpowiedziD = new string[liczbaPytan];
        private string[] poprawnaOdpowiedz = new string[liczbaPytan];
        private string[] obraz = new string[liczbaPytan];
        private int randomNumber;
        private bool[] pytaniaOdp = new bool[liczbaPytan];
        private int iloscOdpowiedzianych = 1;
        private int iloscPoprawnych;


        public void uzupelnij()
        {
            pytania[0] = "Do jakiego województwa należy miasto zaznaczone na mapie?";
            odpowiedziA[0] = "Pomorskie";
            odpowiedziB[0] = "Mazowieckie";
            odpowiedziC[0] = "Warmińsko-Mazurskie";
            odpowiedziD[0] = "śląskie";
            poprawnaOdpowiedz[0] = "C";
            obraz[0] = "wojewodztwo.png";

            pytania[1] = "W którym wieku zostało założone?";
            odpowiedziA[1] = "XII";
            odpowiedziB[1] = "XIV";
            odpowiedziC[1] = "XVI";
            odpowiedziD[1] = "XVIII";
            poprawnaOdpowiedz[1] = "B";
            obraz[1] = "herb.png";

            pytania[2] = "Kto jest patronem miasta?";
            odpowiedziA[2] = "Święta Katarzyna Aleksandryjska ";
            odpowiedziB[2] = "Święty Jan Paweł II";
            odpowiedziC[2] = "Matka Teresa z Kalkuty";
            odpowiedziD[2] = "Święty Maksymilian Maria Kolbe";
            poprawnaOdpowiedz[2] = "A";
            obraz[2] = "herb.png";

            pytania[3] = "Jak nazywa się burmistrz miasta?";
            odpowiedziA[3] = "Bronisław Mazurkiewicz";
            odpowiedziB[3] = "Marek Dwórznik";
            odpowiedziC[3] = "Romuald Remiszewski";
            odpowiedziD[3] = "Grzegorz Mrowiński";
            poprawnaOdpowiedz[3] = "D";
            obraz[3] = "burmistrz.png";

            pytania[4] = "Jaka państwowa instytucja ma swoją siedzibę w budowli przedstawionej na zdjęciu?";
            odpowiedziA[4] = "Urząd Pracy";
            odpowiedziB[4] = "Urząd Skarbowy";
            odpowiedziC[4] = "Urząd Miasta";
            odpowiedziD[4] = "Urząd Gminy";
            poprawnaOdpowiedz[4] = "C";
            obraz[4] = "01.png";


            pytania[5] = "Jakie muzeum mieści się w poniższym budynku";
            odpowiedziA[5] = "Muzeum II wojny światowej";
            odpowiedziB[5] = "Muzeum Solidarności";
            odpowiedziC[5] = "Muezum Państwa Krzyżackiego";
            odpowiedziD[5] = "Muezum emigracji";
            poprawnaOdpowiedz[5] = "C";
            obraz[5] = "ratusz.png";
        }

        public void losuj()
        {
            Random random = new Random();

            while (true)
            {
                randomNumber = random.Next(0, liczbaPytan);

                if (pytaniaOdp[randomNumber] == false )
                {
                    label1.Text = pytania[randomNumber];
                    button1.Text = odpowiedziA[randomNumber];
                    button2.Text = odpowiedziB[randomNumber];
                    button3.Text = odpowiedziC[randomNumber];
                    button4.Text = odpowiedziD[randomNumber];           
                    pictureBox1.Image = new Bitmap(@"C:\Users\Konto\Desktop\Quiz\Quiz\Quiz\" + obraz[randomNumber]);
                    pytaniaOdp[randomNumber] = true;
                    break;
                }
            }

        }

        public void sprawdz(System.Windows.Forms.Button button)
        {
            {
                if (button == button1 && poprawnaOdpowiedz[randomNumber] == "A")
                {
                    button.BackColor = Color.Green;
                    iloscPoprawnych++;
                    label5.Text = iloscPoprawnych.ToString();
                }
                else
                {
                    button.BackColor = Color.Red;
                    if (poprawnaOdpowiedz[randomNumber] == "B") button2.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "C") button3.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "D") button4.BackColor = Color.Green;
                }
            }

            {
                if (button == button2 && poprawnaOdpowiedz[randomNumber] == "B")
                {
                    button.BackColor = Color.Green;
                    iloscPoprawnych++;
                    label5.Text = iloscPoprawnych.ToString();

                }
                else
                {
                    button.BackColor = Color.Red;
                    if (poprawnaOdpowiedz[randomNumber] == "A") button1.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "C") button3.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "D") button4.BackColor = Color.Green;
                }
            }

            {
                if (button == button3 && poprawnaOdpowiedz[randomNumber] == "C")
                {
                    button.BackColor = Color.Green;
                    iloscPoprawnych++;
                    label5.Text = iloscPoprawnych.ToString();

                }
                else
                {
                    button.BackColor = Color.Red;
                    if (poprawnaOdpowiedz[randomNumber] == "A") button1.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "B") button2.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "D") button4.BackColor = Color.Green;
                }
            }

            {
                if (button == button4 && poprawnaOdpowiedz[randomNumber] == "D")
                {
                    button.BackColor = Color.Green;
                    iloscPoprawnych++;
                    label5.Text = iloscPoprawnych.ToString();

                }
                else
                {
                    button.BackColor = Color.Red;
                    if (poprawnaOdpowiedz[randomNumber] == "A") button1.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "B") button2.BackColor = Color.Green;
                    if (poprawnaOdpowiedz[randomNumber] == "C") button3.BackColor = Color.Green;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            uzupelnij();
            this.label2.Text = "1/" + liczbaPytan.ToString();
            losuj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            sprawdz(this.button1);
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (iloscOdpowiedzianych == liczbaPytan - 1) button5.Text = "koniec gry - przejdz do podsumowania";
            if (iloscOdpowiedzianych < liczbaPytan)
            {
                losuj();
                button1.BackColor = default(Color);
                button1.UseVisualStyleBackColor = true;
                button2.BackColor = default(Color);
                button2.UseVisualStyleBackColor = true;
                button3.BackColor = default(Color);
                button3.UseVisualStyleBackColor = true;
                button4.BackColor = default(Color);
                button4.UseVisualStyleBackColor = true;
                iloscOdpowiedzianych++;
                string ilosc = iloscOdpowiedzianych.ToString();
                label2.Text = ilosc + "/" + liczbaPytan.ToString();
                label5.Text = iloscPoprawnych.ToString();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Visible = false;
            }

            else
            {

                End o = new End(iloscPoprawnych, liczbaPytan);
                this.Hide();
                o.ShowDialog();
                this.Close();
                this.Dispose();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            sprawdz(this.button2);
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            sprawdz(this.button3);
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            sprawdz(this.button4);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    
    }
}
