using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;




namespace Auto_power_off
{

    public partial class apo : Form
    {

        public apo()
        {
            InitializeComponent();
        }
        int timer;
        int time;
        private int counter = 60;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            time = int.Parse(comboBox1.Items[comboBox1.SelectedIndex].ToString());
            timer = time * 60;

        }

        private void btnSchovat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
             //Process.Start("shutdown", "/s /t textTimer");
        private void btnStart_Click(object sender, EventArgs e)
        {
            //časovač
            time = int.Parse(comboBox1.Items[comboBox1.SelectedIndex].ToString());
            timer = time * 60;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            // konec časovače 
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void textTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            if (timer == 0)
                timer1.Stop();
             textTimer.Text= timer.ToString(); 
        }
    }
}
