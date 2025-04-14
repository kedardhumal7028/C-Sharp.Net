using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Add = Convert.ToInt32(tbFNo.Text) + Convert.ToInt32(tbSNo.Text);
            tbAns.Text = Add.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int Sub = Convert.ToInt32(tbFNo.Text) - Convert.ToInt32(tbSNo.Text);
            tbAns.Text = Sub.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int Mult = Convert.ToInt32(tbFNo.Text) * Convert.ToInt32(tbSNo.Text);
            tbAns.Text = Mult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double Div = Convert.ToDouble(tbFNo.Text) / Convert.ToDouble(tbSNo.Text);
            tbAns.Text = Div.ToString();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAns.Clear();
            tbFNo.Clear();
            tbSNo.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
