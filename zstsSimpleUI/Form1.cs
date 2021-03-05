using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zstsSimpleUI
{
    public partial class Form1 : Form
    {
        // Don't touch anything here

        public string str_;
        public int count_;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     
          int nTopRect,      
          int nRightRect,    
          int nBottomRect,   
          int nWidthEllipse, 
          int nHeightEllipse 
      );

        // Ending


        // Edit below this.



        public Form1()
        {

            // Don't touch anything here
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeComponent();
            // Ending

            // Edit below this.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Don't touch anything here
            
            count_ = 1;
            str_ = "zstsSimpleUI"; // EDIT THIS TO YOUR OWN TEXT
            timer1.Enabled = true;
            // Ending

            // Edit below this.

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length == str_.Length)
            {
                timer1.Enabled = false;
                return;
            }
            label1.Text = str_.Substring(0, count_);
            count_++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
