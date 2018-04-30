using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// TODO # - Add a reference to your library after you've coded and built it and 
//          then add a using directive.
using FroELibSpring17;





namespace Ch16Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // TODO # - Call a method from personal lib that displays programmer info
            MyMethods.AboutEugene();
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool goodNum1 = false;
            bool goodNum2 = false;
            decimal num1 = 0;
            decimal num2 = 0;

            // Attempt to get valid input (two decimals)
            goodNum1 = decimal.TryParse(txtNum1.Text, out num1);
            goodNum2 = decimal.TryParse(txtNum2.Text, out num2);

	        if (goodNum1 && goodNum2)
            {
                // TODO # - Add numbers using method from personal library
                txtSum.Text = MyMethods.AddTwo(num1, num2).ToString();
              
                     
            }
            else
            {
                MessageBox.Show("Invalid data. Enter numbers only.");
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            SecretForm frm = new SecretForm();
            frm.ShowDialog();
        }
    }
}
