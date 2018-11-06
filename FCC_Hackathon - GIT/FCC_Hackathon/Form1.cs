using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCC_Hackathon
{
    public partial class Form1 : Form
    {
        static public bool myAppRunning { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            myAppRunning = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            myAppRunning = false;
        }
    }
}
