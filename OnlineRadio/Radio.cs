using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRadio
{
    public partial class Radio : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        public Radio()
        {
            InitializeComponent();
        }

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;
        }

        private void titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Radio_FormClosed(object sender, FormClosedEventArgs e)

        {

            //exit application when form is closed

            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Radio_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.154.254.81/stream.mp3?ipport=95.154.254.81_29021";
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shaincast.caster.fm:47814/listen.mp3";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://live.trusl.com:1152/;?type=http&nocache=0";
            pictureBox1.Image = Properties.Resources.yes;
        }

        private void btnHiruFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://209.133.216.3:7018/;stream.mp3";
            pictureBox1.Image = Properties.Resources.hiru;

        }

        private void btnNethFM_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://69.46.24.226:7669/stream";
            pictureBox1.Image = Properties.Resources.neth2;
        }

        private void btnRasa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shaincast.caster.fm:47814/listen.mp3";
            pictureBox1.Image = Properties.Resources.rasa;
        }

        private void btnSirasa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://76.164.217.100:7024/;stream.mp3";
            pictureBox1.Image = Properties.Resources.sirasa;
        }

        private void btnShaa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://209.133.216.3:7073/;stream.mp3";
            pictureBox1.Image = Properties.Resources.shaa;
        }

        private void btnDerana_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://109.123.114.30:7130/;";
            pictureBox1.Image = Properties.Resources.derana;
        }

        private void btnRhythm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://cdn2.streamcase.net:8030/live.mp3";
            pictureBox1.Image = Properties.Resources.rhythm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Lak FM
            axWindowsMediaPlayer1.URL = "http://108.61.34.50:8054/;stream.mp3";
            pictureBox1.Image = Properties.Resources.lak;
        }

        private void btnITN_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://93.190.141.15:7271/stream.mp3";
            pictureBox1.Image = Properties.Resources.itn;
        }

        private void btnSiyatha_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://s3.voscast.com:8408/.mp3";
            pictureBox1.Image = Properties.Resources.siyatha;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://54.255.246.186:8001/;";
            pictureBox1.Image = Properties.Resources.v;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://live.trusl.com:1180/;?type=http&nocache=0";
            pictureBox1.Image = Properties.Resources.y;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt");
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://220.247.227.20:8000/citystream?1532142198306.mp3";
            pictureBox1.Image = Properties.Resources.city;
        }

        private void btnSwadeshiya_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://220.247.227.6:8000/Snsstream";
            pictureBox1.Image = Properties.Resources.swadeshiya;
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://209.133.216.3:7048/;stream.mp3";
            pictureBox1.Image = Properties.Resources.gold;
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://209.133.216.3:7058/;stream.mp3";
            pictureBox1.Image = Properties.Resources.sun;
        }

        private void btnKiss_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://s3.voscast.com:8404/;stream1472803644663/1";
            pictureBox1.Image = Properties.Resources.kiss;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shaincast.caster.fm:47830/listen.mp3";
            pictureBox1.Image = Properties.Resources.red;
        }

        private void btnLite_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://cdn2.streamcase.net:8020/live.mp3";
            pictureBox1.Image = Properties.Resources.lite;
        }

        private void btntnl_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://cdn2.streamcase.net:8010/live.mp3";
            pictureBox1.Image = Properties.Resources.tnl;
        }

        private void btnTharu_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://146.185.18.251:7014/;stream.mp3";
            pictureBox1.Image = Properties.Resources.tharu;
        }

        private void btnSooriyan_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://209.133.216.3:7071/;stream.mp3";
            pictureBox1.Image = Properties.Resources.sooriyan;
        }

        private void btnVasantham_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://76.164.217.100:7489/;stream/1";
            pictureBox1.Image = Properties.Resources.vasantham;
        }

        private void btnShakthi_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://live.trusl.com:1160/;?type=http&nocache=0";
            pictureBox1.Image = Properties.Resources.shakthi;
        }

        private void btnBuddhist_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.154.254.81/stream.mp3?ipport=95.154.254.81_29021";
            pictureBox1.Image = Properties.Resources.buddhist;
        }

        private void btnLakviru_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://69.46.24.226:7643/;?1532142000555";
            pictureBox1.Image = Properties.Resources.lakviru;
        }

        private void btnRangiri_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://109.123.114.30:7000/live";
            pictureBox1.Image = Properties.Resources.rangiri;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.exit1;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.exit0;
        }
    }
}
