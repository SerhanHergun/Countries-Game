using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace Serhan_Hergun_Kerem_Ozer_ulkeler_oyunu
{
    public partial class Form2 : Form
    {
        
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
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
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        int RastgeleSayi;
        Random rast = new Random();

        int toplam = 10;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    comboBox1.Items.Add(prop.Name);
                comboBox2.Items.Add(prop.Name);
                comboBox3.Items.Add(prop.Name);
            }
            RastgeleSayi = rast.Next(1, 11);

            if (RastgeleSayi == 1)
            {

                türk.Play();
                label1.Text = "TÜRKİYE";


            }
            if (RastgeleSayi == 2)
            {

                Almanya.Play();
                label1.Text = "ALMANYA";

            }
            if (RastgeleSayi == 3)
            {

                Avusturya.Play();
                label1.Text = "AVUSTURYA";

            }
            if (RastgeleSayi == 4)
            {

                Litvanya.Play();
                label1.Text = "LİTVANYA";

            }
            if (RastgeleSayi == 5)
            {

                Bulgaristan.Play();
                label1.Text = "BULGARİSTAN";

            }
            if (RastgeleSayi == 6)
            {

                Estonya.Play();
                label1.Text = "ESTONYA";

            }
            if (RastgeleSayi == 7)
            {

                Yemen.Play();
                label1.Text = "YEMEN";

            }
            if (RastgeleSayi == 8)
            {

                Hollanda.Play();
                label1.Text = "HOLLANDA";

            }
            if (RastgeleSayi == 9)
            {

                Rusya.Play();
                label1.Text = "RUSYA";

            }
            if (RastgeleSayi == 10)
            {

                Lüksemburg.Play();
                label1.Text = "LÜKSEMBURG";

            }
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color renk = Color.FromName(comboBox1.Text);
            listBox1.BackColor = renk;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color renk = Color.FromName(comboBox2.Text);
            listBox2.BackColor = renk;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color renk = Color.FromName(comboBox3.Text);
            listBox3.BackColor = renk;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            listBox1.BackColor = Color.FromArgb(255, 255, 255);
            listBox2.BackColor = Color.FromArgb(255, 255, 255);
            listBox3.BackColor = Color.FromArgb(255, 255, 255);
            label2.Text = "";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";

            RastgeleSayi = rast.Next(1, 11);

            if (RastgeleSayi == 1)
            {

                türk.Play();
                label1.Text = "TÜRKİYE";


            }
            if (RastgeleSayi == 2)
            {

                Almanya.Play();
                label1.Text = "ALMANYA";

            }
            if (RastgeleSayi == 3)
            {

                Avusturya.Play();
                label1.Text = "AVUSTURYA";

            }
            if (RastgeleSayi == 4)
            {

                Litvanya.Play();
                label1.Text = "LİTVANYA";

            }
            if (RastgeleSayi == 5)
            {

                Bulgaristan.Play();
                label1.Text = "BULGARİSTAN";

            }
            if (RastgeleSayi == 6)
            {

                Estonya.Play();
                label1.Text = "ESTONYA";

            }
            if (RastgeleSayi == 7)
            {

                Yemen.Play();
                label1.Text = "YEMEN";

            }
            if (RastgeleSayi == 8)
            {

                Hollanda.Play();
                label1.Text = "HOLLANDA";

            }
            if (RastgeleSayi == 9)
            {

                Rusya.Play();
                label1.Text = "RUSYA";

            }
            if (RastgeleSayi == 10)
            {

                Lüksemburg.Play();
                label1.Text = "LÜKSEMBURG";

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "***";
            if (RastgeleSayi == 1 && comboBox1.SelectedIndex == 114 && comboBox2.SelectedIndex == 114 && comboBox3.SelectedIndex == 114)
            {
                label2.Text = "10 PUAN KAZANDINIZ";


            }
            if (RastgeleSayi == 2 && comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 114 && comboBox3.SelectedIndex == 139)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 3 && comboBox1.SelectedIndex == 114 && comboBox2.SelectedIndex == 137 && comboBox3.SelectedIndex == 114)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 4 && comboBox1.SelectedIndex == 139 && comboBox2.SelectedIndex == 52 && comboBox3.SelectedIndex == 114)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 5 && comboBox1.SelectedIndex == 137 && comboBox2.SelectedIndex == 52 && comboBox3.SelectedIndex == 114)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 6 && comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 8 && comboBox3.SelectedIndex == 137)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 7 && comboBox1.SelectedIndex == 114 && comboBox2.SelectedIndex == 137 && comboBox3.SelectedIndex == 8)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 8 && comboBox1.SelectedIndex == 114 && comboBox2.SelectedIndex == 137 && comboBox3.SelectedIndex == 10)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 9 && comboBox1.SelectedIndex == 10 && comboBox2.SelectedIndex == 137 && comboBox3.SelectedIndex == 114)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            if (RastgeleSayi == 10 && comboBox1.SelectedIndex == 114 && comboBox2.SelectedIndex == 137 && comboBox3.SelectedIndex == 10)
            {
                label2.Text = "10 PUAN KAZANDINIZ";

            }
            
            if (label2.Text == "10 PUAN KAZANDINIZ")
            {
                
                label4.Text = $"Toplam Puanın = {toplam}";
                toplam = toplam + 10;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RastgeleSayi == 1)
            {
                MessageBox.Show("RED,RED,RED");
            }
            if (RastgeleSayi == 2)
            {
                MessageBox.Show("BLACK,RED,YELLOW");
            }
            if (RastgeleSayi == 3)
            {
                MessageBox.Show("RED,WHITE,RED");
            }
            if (RastgeleSayi == 4)
            {
                MessageBox.Show("YELLOW,GREEN,RED");
            }
            if (RastgeleSayi == 5)
            {
                MessageBox.Show("WHİTE,GREEN,RED");
            }
            if (RastgeleSayi == 6)
            {
                MessageBox.Show("BLUE,BLACK,WHİTE");
            }
            if (RastgeleSayi == 7)
            {
                MessageBox.Show("RED,WHİTE,BLACK");
            }
            if (RastgeleSayi == 8)
            {
                MessageBox.Show("RED,WHİTE,BLUE");
            }
            if (RastgeleSayi == 9)
            {
                MessageBox.Show("BLUE,WHİTE,RED");
            }
            if (RastgeleSayi == 10)
            {
                MessageBox.Show("RED,WHİTE,BLUE");
            }
        }

       
            
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (RastgeleSayi == 1)
            {
                MessageBox.Show("İstiklal Marşı");
            }
            if (RastgeleSayi == 2)
            {
                MessageBox.Show("Das Lied der Deutschen");
            }
            if (RastgeleSayi == 3)
            {
                MessageBox.Show("Land der Berge");
            }
            if (RastgeleSayi == 4)
            {
                MessageBox.Show("Tautiška giesmė");
            }
            if (RastgeleSayi == 5)
            {
                MessageBox.Show("Mila Rodino");
            }
            if (RastgeleSayi == 6)
            {
                MessageBox.Show("Mu isamaa, mu õnn ja rõõm");
            }
            if (RastgeleSayi == 7)
            {
                MessageBox.Show("Al-Jomhuriyah Al-Mottaḥedah");
            }
            if (RastgeleSayi == 8)
            {
                MessageBox.Show("Wilhelmus");
            }
            if (RastgeleSayi == 9)
            {
                MessageBox.Show("Государственный гимн Российской Федерации");
            }
            if (RastgeleSayi == 10)
            {
                MessageBox.Show("Ons Heemecht");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Form1 yeniform1 = new Form1();
            yeniform1.Show();
        }

        
    }
}
  
