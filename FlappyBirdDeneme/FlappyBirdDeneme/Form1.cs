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

namespace FlappyBirdDeneme
{
    public partial class Form1 : Form
    {
        int boruHızı = 4;
        int yerÇekimi = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameTimerEvents(object sender, EventArgs e)
        {
            pcboxKuş.Top += yerÇekimi;
            pcboxAltBoru.Left -= boruHızı;
            pcboxÜstBoru.Left -= boruHızı;
            lblSkor.Text = "Skor :" + score;

            if(pcboxAltBoru.Left<-150)
            {
                pcboxAltBoru.Left = 700;
                score++;
            }

            if (pcboxÜstBoru   .Left < -150)
            {
                pcboxÜstBoru.Left = 700;
                score++;
            }

            if(pcboxKuş.Bounds.IntersectsWith(pcboxAltBoru.Bounds)||pcboxKuş.Bounds.IntersectsWith(pcboxÜstBoru.Bounds)||pcboxKuş.Bounds.IntersectsWith(pcboxZemin.Bounds))
            {
                oyunBitti();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                yerÇekimi = -5;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
               

                yerÇekimi = 5;
            }
        }

        private void oyunBitti()
        {
            gameTimer.Stop();
            lblSkor.Text = "Game Over !";

            DialogResult result1 = MessageBox.Show("Yeniden başlamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent(); 
            }
            else
            {
                 this.Close();
            }
        }
   
       void basla()
       {
            startTimer.Enabled = true;
       }










        //System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        //ses.SoundLocation = "montaj-icin-ses-efekti-mario-ziplama-sesi-dooiingg.wav";
        //ses.Play();





        private void pcboxKuş_Click(object sender, EventArgs e)
        {

        }
    }
}
