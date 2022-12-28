using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotrFanPageUwU
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.ImageLocation = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\SmaugFire2.gif";
            pictureBox2.Load();
            pictureBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox3.ImageLocation = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\SmaugFlying.gif";
            pictureBox3.Load();
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\SmaugSpeak.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

        }
    }
}
