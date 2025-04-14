using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YC_Student_Admission_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "User" && tb_Password.Text == "a123")
            {
                MessageBox.Show("Login Succesfull", "Sucess", MessageBoxButtons.OK);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Correct username and password", "Error",MessageBoxButtons.OK);
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Username.Clear();
            tb_Password.Clear();
        }

    }
}
