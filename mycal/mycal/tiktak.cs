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
    public partial class tiktak : Form
    {
        public tiktak()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
       
        private void bclick(object sender, EventArgs e)
        {



        }
        private void disablebuttons(object sender, EventArgs e) {
            
        
        }
        private void tiktak_Load(object sender, EventArgs e)
        {
           
        }

      
       

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        
        private void button2_Click(object sender, EventArgs e)
        {

            tiktak tk = new tiktak();
            
            multi ml=new multi();
            ml.Show();
            this.Hide();
           
          


        }

        private void b3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
