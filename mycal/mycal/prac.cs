using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycal
{
    public partial class prac : Form
    {
        public prac()
        {
            InitializeComponent();
        }

        private void prac_Load(object sender, EventArgs e)
        {

        }
        double ans,ans1;
   
        double a,b;
        int c, d;

        private void b2_Click(object sender, EventArgs e)
        {
            c=Convert.ToInt16(t1.Text);
            d= Convert.ToInt16(t2.Text);
            a= Convert.ToInt16(n3.Value);    

            ans1 = (c*d)*a / 100;
            t3.Text = ans1.ToString();

        }

        private void n3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void n1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void n2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "E:\\";
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
