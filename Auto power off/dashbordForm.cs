using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textTimer_TextChanged(object sender, EventArgs e)
        {
            //Process.Start("shutdown", "/s /t textTimer");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String time;
            time = comboBox1.Text;
            
            textTimer.Text = time;
        }
    }
}
