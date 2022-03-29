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
    public partial class tabs : Form
    {
        public tabs()
        {
            InitializeComponent();
        }
        int count2 = 0;
        bool check=true;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = check;
            check = true;
        }
        private void Next_Click(object sender, EventArgs e)
        {


            check = false;



            if (math.Checked && comp.CheckState == CheckState.Unchecked && phy.CheckState == CheckState.Unchecked && isl.CheckState == CheckState.Unchecked) {
                
                tabControl1.SelectTab("tabpage2");
                computers.Hide();
                physics.Hide();
                islamiyat.Hide();
                maths.Visible = true;
            
            }
            else if (comp.Checked && math.CheckState == CheckState.Unchecked && phy.CheckState == CheckState.Unchecked && isl.CheckState == CheckState.Unchecked) {
               
                tabControl1.SelectTab("tabpage2");
                computers.Visible = true;
                maths.Hide();
                physics.Hide();
                islamiyat.Hide();
            }
            else if (phy.Checked && math.CheckState == CheckState.Unchecked && comp.CheckState == CheckState.Unchecked && isl.CheckState == CheckState.Unchecked)
            {
                
                tabControl1.SelectTab("tabpage2");
                computers.Visible = true;
                maths.Hide();
                computers.Hide();
                islamiyat.Hide();
            }

            else if (isl.Checked && math.CheckState == CheckState.Unchecked && comp.CheckState == CheckState.Unchecked && phy.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                islamiyat.Visible = true;
                maths.Hide();
                computers.Hide();
                physics.Hide();
            }


            else if (comp.Checked && math.Checked && isl.CheckState == CheckState.Unchecked && phy.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                maths.Visible = true;
                computers.Visible = true;
                physics.Hide();
                islamiyat.Hide();

            }
            else if (phy.Checked && math.Checked && comp.CheckState == CheckState.Unchecked && isl.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                maths.Visible = true;
                physics.Visible = true;
                islamiyat.Hide();
                computers.Hide();

            }
            else if (isl.Checked && math.Checked && comp.CheckState == CheckState.Unchecked && phy.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                maths.Visible = true;
                islamiyat.Visible = true;
                computers.Hide();
                physics.Hide();
            }

            else if (comp.Checked && phy.Checked && math.CheckState == CheckState.Unchecked && isl.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                physics.Visible = true;
                computers.Visible = true;
                islamiyat.Hide();
                maths.Hide();

            }
            else if (comp.Checked && isl.Checked && math.CheckState == CheckState.Unchecked && phy.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                islamiyat.Visible = true;
                computers.Visible = true;
                maths.Hide();
                physics.Hide();
            }
            else if (phy.Checked && isl.Checked && math.CheckState == CheckState.Unchecked && comp.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                physics.Visible = true;
                islamiyat.Visible = true;
                computers.Hide();
                maths.Hide();
            }

            else if (phy.Checked && comp.Checked && math.Checked && isl.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                physics.Visible = true;
                computers.Visible=true;
                maths.Visible=true;
                islamiyat.Hide();
            }
            else if (isl.Checked && comp.Checked && math.Checked && phy.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                physics.Hide();
                islamiyat.Visible = true;
                computers.Visible = true;
                maths.Visible = true;
            }
            else if (phy.Checked && isl.Checked && math.Checked && comp.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                physics.Visible = true;
                islamiyat.Visible = true;
                computers.Hide();
                maths.Visible = true;
            }

            else if (phy.Checked && comp.Checked && isl.Checked && math.CheckState == CheckState.Unchecked)
            {

                tabControl1.SelectTab("tabpage2");
                physics.Visible = true;
                islamiyat.Visible = true;
                computers.Visible = true;
                maths.Hide();
            }
            else if (phy.Checked && comp.Checked && isl.Checked && math.Checked)
            {
                Next.Enabled= false;
                MessageBox.Show("Select Only Three Options");
               
            }
            else if (phy.CheckState==CheckState.Unchecked && comp.CheckState == CheckState.Unchecked && math.CheckState == CheckState.Unchecked && isl.CheckState == CheckState.Unchecked)
            {
                Next.Enabled = false;
                check = false;
                tabControl1.SelectTab("tabpage2");
                MessageBox.Show("Select Your option");
               

            }





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabs_Load(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        int count=0;
       
        bool val;
        private void maths_Enter(object sender, EventArgs e)
        {
            

        }

        private void ma1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabpage3");
            count1.Text = count.ToString();
            wrong.Text = count2.ToString();
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            r1.Checked = true;
            count++;
        }

        private void r6_CheckedChanged(object sender, EventArgs e)
        {
            r6.Checked = true;
            count++;
        }

        private void r8_CheckedChanged(object sender, EventArgs e)
        {
            r8.Checked = true;
            count++;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            count++;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            count++;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            count++;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            radioButton11.Checked = true;
            count++;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton15.Checked = true;
            count++;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton18.Checked = true;
            count++;
        }

        private void result_Click(object sender, EventArgs e)
        {
            

        }

        private void count1_Click(object sender, EventArgs e)
        {
          
        }

        private void r3_CheckedChanged(object sender, EventArgs e)
        {
            r3.Checked = true;
            count2++;
        }

        private void r2_CheckedChanged(object sender, EventArgs e)
        {
            r2.Checked = true;
            count2++;
        }

        private void r4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void r7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void r9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
