using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu
{
    public partial class Form3 : Form
    {

        string[] sor = { "Almanya", "Avusturya", "Türkiye", "Litvanya", "Bulgaristan", "Estonya", "Ukrayna", "Hollanda", "Rusya", "Lüksemburg" };

        string cc = "tr";
        int c = 0;

        public SoundPlayer dogruu = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.dogri);
        public SoundPlayer yanlii = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.yanli);
        public SoundPlayer türk = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._1);
        public SoundPlayer Almanya = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._2);
        public SoundPlayer Avusturya = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._3);
        public SoundPlayer Litvanya = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._4);
        public SoundPlayer Bulgaristan = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._5);
        public SoundPlayer Estonya = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._6);
        public SoundPlayer Yemen = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._7);
        public SoundPlayer Hollanda = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._8);
        public SoundPlayer Rusya = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._9);
        public SoundPlayer Lüksemburg = new SoundPlayer(Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources._10);






        public Form3()
        {
            InitializeComponent();

        }
     




        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                dogruu.Play();

            }
            else if (c == 2)
            {
                yanlii.Play();
            }
            else if (c == 3)
            {
                yanlii.Play();
            }
            else if (c == 4)
            {
                yanlii.Play();
            }
            else if (c == 5)
            {
                dogruu.Play();
            }
            else if (c == 6)
            {
                dogruu.Play();
            }
            else if (c == 7)
            {
                dogruu.Play();
            }
            else if (c == 8)
            {
                yanlii.Play();
            }
            else if (c == 9)
            {
                yanlii.Play();
            }
            else if (c == 10)
            {
                yanlii.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                yanlii.Play();

            }
            else if (c == 2)
            {
                dogruu.Play();
            }
            else if (c == 3)
            {
                dogruu.Play();
            }
            else if (c == 4)
            {
                dogruu.Play();
            }
            else if (c == 5)
            {
                yanlii.Play();
            }
            else if (c == 6)
            {
                yanlii.Play();
            }
            else if (c == 7)
            {
                yanlii.Play();
            }
            else if (c == 8)
            {
                yanlii.Play();
            }
            else if (c == 9)
            {
                yanlii.Play();
            }
            else if (c == 10)
            {
                yanlii.Play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                yanlii.Play();
            }
            else if (c == 2)
            {
                yanlii.Play();
            }
            else if (c == 3)
            {
                yanlii.Play();
            }
            else if (c == 4)
            {
                yanlii.Play();
            }
            else if (c == 5)
            {
                yanlii.Play();
            }
            else if (c == 6)
            {
                yanlii.Play();
            }
            else if (c == 7)
            {
                yanlii.Play();
            }
            else if (c == 8)
            {
                dogruu.Play();
            }
            else if (c == 9)
            {
                dogruu.Play();
            }
            else if (c == 10)
            {
                dogruu.Play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Sıradaki Soru";
            if (c == 10)
            {

                c = 0;
            }

            label1.Text = ($"Aşağıdakilerden hangisi {sor[c]} ülkesinin bayrağıdır?");
            if (c == 0)
            {
                Almanya.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.alm);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lt);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.tr);

            }
            else if (c == 1)
            {
                Avusturya.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.hol);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.avt);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lkbrg);

            }
            else if (c == 2)
            {
                türk.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.ee);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.tr);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.avt);
            }

            else if (c == 3)
            {
                Litvanya.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.hol);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lt);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.alm);
            }
            else if (c == 4)
            {
                Bulgaristan.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.blg);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.tr);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lkbrg);
            }
            else if (c == 5)
            {
                Estonya.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.ee);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.rss);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.avt);
            }
            else if (c == 6)
            {
                Yemen.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.uk);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.alm);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lt);
            }
            else if (c == 7)
            {
                Hollanda.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.tr);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lkbrg);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.hol);
            }
            else if (c == 8)
            {
                Rusya.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.ee);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.avt);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.rss);
            }
            else if (c == 9)
            {
                Lüksemburg.Play();
                button1.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.tr);
                button2.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.ee);
                button3.Image = (Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu.Properties.Resources.lkbrg);
            }


            c++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 yeniform1 = new Form1();
            yeniform1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
