using AxWMPLib;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.ImageLocation = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\EntsGoingWar.gif";
            pictureBox2.Load();
            pictureBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.ImageLocation = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\EntsWalkk.gif";
            pictureBox3.Load();
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\EntSong (online-audio-converter.com).wav");
            sound.Play();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
    }
}
