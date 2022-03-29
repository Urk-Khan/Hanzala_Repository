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
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void app_Load(object sender, EventArgs e)
        { }
        int b, f, l,i;

        private void base1_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt16(base1.Text);
        }

       

        private void app_Load_1(object sender, EventArgs e)
        {

        }

      
        private void lim1_TextChanged(object sender, EventArgs e)
        {
            l = Convert.ToInt16(lim1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            f = Convert.ToInt16(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                for (i = b; i < l; i=i*f)
                {

                    lb1.Items.Add(i);
                    

                }
           
            }

       
    }
}
