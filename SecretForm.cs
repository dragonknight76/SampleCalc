using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FroELibSpring17;


namespace Ch16Practice
{
    public partial class SecretForm : Form
    {
        public SecretForm()
        {
            InitializeComponent();
        }

        private void SecretForm_Load(object sender, EventArgs e)
        {
            // TODO 
            lblOutput.Text = MyMethods.DisplayQuote();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // TODO Set a couple of properties of the timer control
            this.Close();
        }
    }
}
