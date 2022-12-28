using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotrFanPageUwU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.ImageLocation = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\BomburEating.gif";
            pictureBox2.Load();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\\Users\\user\\source\\repos\\LotrFanPageUwU\\LotrFanPageUwU\\Resources\\BomburSnore.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\bomburSoong (online-audio-converter.com).wav");
            sound.Play();
            pictureBox2.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
        }
    }
}
