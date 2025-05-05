using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartialClass
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }
        private void LoadFormIntoPanel(Form form)
        {
            panel2.Controls.Clear(); // Clear existing controls
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            LoadFormIntoPanel(registerForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            LoadFormIntoPanel(loginForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator calculatorForm = new Calculator();
            LoadFormIntoPanel(calculatorForm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void startTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;

        }

        private void stopTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label2.Visible = false;
        }
    }
        
}
