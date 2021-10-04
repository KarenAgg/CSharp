using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formcal : Form
    {
        public formcal()
        {
            InitializeComponent();
        }

        private void rbadicao_CheckedChanged(object sender, EventArgs e)
        {
                int num1 = int.Parse(txtnum1.Text);
                int num2 = int.Parse(txtnum2.Text);
                int adicao = (num1 + num2);
                txtresult.Text = adicao.ToString();    
        }

        private void rbsub_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int sub = (num1 - num2);
            txtresult.Text = sub.ToString();
        }

        private void rbmult_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int mult = (num1 * num2);
            txtresult.Text = mult.ToString();
        }

        private void rbdiv_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int div = (num1 / num2);
            txtresult.Text = div.ToString();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresult.Text = "";

            txtnum1.Focus();
        }

        private void formcal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
