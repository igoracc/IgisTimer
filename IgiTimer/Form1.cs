using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IgiTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = textBox2.Text;
            timer1.Interval = Convert.ToInt32(textBox1.Text) * 60000;
            timer1.Enabled = true;

            notifyIcon1.ShowBalloonTip(Convert.ToInt32(textBox1.Text) * 60000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(Convert.ToInt32(textBox1.Text) * 6000);
        }
    }
}
