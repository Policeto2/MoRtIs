using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttsdemonic
{
    public partial class Form1 : Form
    {

        static Random r;

        static Form1() {
            r = new Random();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown2.Enabled = checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "";
            cmd += (checkBox1.Checked) ? " -pitch " + numericUpDown1.Value : "";
            cmd += (checkBox2.Checked) ? " -mouth " + numericUpDown2.Value : "";
            cmd += (checkBox3.Checked) ? " -speed " + numericUpDown3.Value : "";
            cmd += (checkBox4.Checked) ? " -throat " + numericUpDown4.Value : "";
            cmd += (checkBox5.Checked) ? " -sing ":"";
            cmd += (checkBox6.Checked) ? " -phonetic" : "";
            cmd += " " + textBox1.Text;
            Process.Start(@"sam.exe", cmd);
            /* felurgró ablak kérdés
             * 
             * if (MessageBox.Show(@"SAM\sam.exe " + cmd, "amit futattunk", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.Blue;
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox1.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown3.Enabled = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown4.Enabled = checkBox4.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
    }
}
