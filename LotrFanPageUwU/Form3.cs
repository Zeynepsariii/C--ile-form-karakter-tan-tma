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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.ImageLocation = @"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\NazgulFlying.gif";
            pictureBox2.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\user\source\repos\LotrFanPageUwU\LotrFanPageUwU\Resources\NazgulScream.wav");
            sound.Play();
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
            
        }
    }
}
