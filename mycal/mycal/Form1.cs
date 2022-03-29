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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void data_TextChanged(object sender, EventArgs e)
        {

        }
        float fn, sn;
        double rs;
        int opt;
        private void button_Click(object sender, EventArgs e)
        {
            {
                if (data.Text == "0")
                {

                    data.Clear();
                }
                Button button = (Button)sender;
                data.Text = data.Text + button.Text;





            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Button b2 = (Button)sender;
            data.Text = data.Text + b2.Text;

        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);

                data.Text = "";
                opt = 1;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Button b3 = (Button)sender;
            data.Text = data.Text + b3.Text;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 2;
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 3;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 4;
            }
        }

        private void point_Click(object sender, EventArgs e)
        {

            Button point = (Button)sender;
            data.Text = data.Text + point.Text;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 5;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            data.Text = "";
        }

        private void zaro_Click(object sender, EventArgs e)
        {
            Button zaro = (Button)sender;
            data.Text = data.Text + zaro.Text;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 6;
                calculate();
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sn = (float)Convert.ToDecimal(data.Text);

                calculate();
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 7;
                calculate();
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 8;
                calculate();
            }
        }

        private void sininv_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 9;
                calculate();
            }
        }

        private void taninv_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 10;
                calculate();
            }
        }

        private void cosinv_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 11;
                calculate();
            }

        }

        private void underroot_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 12;
                calculate();
            }
        }

        private void sqr_Click(object sender, EventArgs e)

        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 13;
                calculate();
            }
        }

        private void cude_Click(object sender, EventArgs e)
        {
            if (data.Text == "")
            {

                MessageBox.Show("Invalid Entry", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fn = (float)Convert.ToDecimal(data.Text);
                data.Text = "";
                opt = 14;
                calculate();
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void calculate()
        {

            switch (opt)

            {
                case 1:
                    rs = fn + sn;
                    data.Text = rs.ToString();
                    break;
                case 2:
                    rs = fn - sn;
                    data.Text = rs.ToString();
                    break;
                case 3:
                    rs = fn * sn;
                    data.Text = rs.ToString();
                    break;
                case 4:
                    rs = fn / sn;
                    data.Text = rs.ToString();
                    break;
                case 5:
                    rs = (fn / 100) * sn;
                    data.Text = rs.ToString();
                    break;
                case 6:
                    rs = Math.Cos(fn);
                    data.Text = rs.ToString();
                    break;
                case 7:
                    rs = Math.Sin(fn);
                    data.Text = rs.ToString();
                    break;
                case 8:
                    rs = Math.Tan(fn);
                    data.Text = rs.ToString();
                    break;
                case 9:
                    rs = Math.Acos(fn);
                    data.Text = rs.ToString();
                    break;
                case 10:
                    rs = Math.Asin(fn);
                    data.Text = rs.ToString();
                    break;
                case 11:
                    rs = Math.Atan(fn);
                    data.Text = rs.ToString();
                    break;
                case 12:
                    rs = Math.Sqrt(fn);
                    data.Text = rs.ToString();
                    break;
                case 13:
                    rs = fn * fn;
                    data.Text = rs.ToString();
                    break;
                case 14:
                    rs = fn * fn * fn;
                    data.Text = rs.ToString();
                    break;


                default:
                    break;

            }


        }

    }
}

