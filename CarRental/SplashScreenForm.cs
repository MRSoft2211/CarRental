using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRental
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
            if (panel3.Width>=800)
            {
                timer1.Stop();
                GirisForm frm = new GirisForm();
                this.Hide();
                frm.ShowDialog();
                
            }
            else if (panel3.Width >= 700)
            {
                panel3.Width += 3;
            }
            else if (panel3.Width >= 450)
            {
                panel3.Width += 8;
            }
            else if (panel3.Width >= 100)
            {
                panel3.Width += 7;
            }
            else if (panel3.Width >= 44)
            {
                panel3.Width += 5;
            }



        }
    }
}
