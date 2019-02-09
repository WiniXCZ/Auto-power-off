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
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);

        int timer;
        int time;

        public apo()
        {
            InitializeComponent();
        }

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
        private void btnStart_Click(object sender, EventArgs e)
        {
            //časovač
            time = int.Parse(comboBox1.Items[comboBox1.SelectedIndex].ToString());
            timer = time * 60;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
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
            textTimer.Text = timer.ToString();
            timer--;
            if (timer == 0)
            {
                timer1.Stop();
            }

            if (timer == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    ExitWindowsEx(1, 0);
                    timer1.Stop();
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    ExitWindowsEx(2, 0);
                    timer1.Stop();
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    timer1.Stop();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    ExitWindowsEx(0 | 0x00000004, 0);
                    timer1.Stop();

                }
                else
                {
                    ExitWindowsEx(1, 0);
                    timer1.Stop();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
