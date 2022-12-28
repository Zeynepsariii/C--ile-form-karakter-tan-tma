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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Visible = true;
            axWindowsMediaPlayer2.URL = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\LegolasElvish.mp4";
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Visible=false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\LegolasArrow.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Visible = false;
        }
    }
}
