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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_RollNo.Clear();
            tb_Std_Name.Clear();
            tb_MobNo.Clear();
            dtp_DOB.Value = DateTime.Now;
            cmb_Course.Items.Clear();

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Std_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }
    }
}
