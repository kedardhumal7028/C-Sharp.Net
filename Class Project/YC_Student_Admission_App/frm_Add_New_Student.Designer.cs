
namespace YC_Student_Admission_App
{
    partial class frm_Add_New_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Student));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_Std_Name = new System.Windows.Forms.TextBox();
            this.tb_RollNo = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Std_Name = new System.Windows.Forms.Label();
            this.lbl_RollNo = new System.Windows.Forms.Label();
            this.lbl_Mob = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_MobNo = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Std_List = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Location = new System.Drawing.Point(339, 19);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(101, 13);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "Add Student Details";
            // 
            // tb_Std_Name
            // 
            this.tb_Std_Name.Location = new System.Drawing.Point(385, 155);
            this.tb_Std_Name.Name = "tb_Std_Name";
            this.tb_Std_Name.Size = new System.Drawing.Size(141, 20);
            this.tb_Std_Name.TabIndex = 2;
            this.tb_Std_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_RollNo
            // 
            this.tb_RollNo.Location = new System.Drawing.Point(385, 95);
            this.tb_RollNo.Name = "tb_RollNo";
            this.tb_RollNo.Size = new System.Drawing.Size(141, 20);
            this.tb_RollNo.TabIndex = 1;
            this.tb_RollNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(400, 405);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(255, 405);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Std_Name
            // 
            this.lbl_Std_Name.AutoSize = true;
            this.lbl_Std_Name.Location = new System.Drawing.Point(255, 158);
            this.lbl_Std_Name.Name = "lbl_Std_Name";
            this.lbl_Std_Name.Size = new System.Drawing.Size(75, 13);
            this.lbl_Std_Name.TabIndex = 9;
            this.lbl_Std_Name.Text = "Student Name";
            // 
            // lbl_RollNo
            // 
            this.lbl_RollNo.AutoSize = true;
            this.lbl_RollNo.Location = new System.Drawing.Point(255, 95);
            this.lbl_RollNo.Name = "lbl_RollNo";
            this.lbl_RollNo.Size = new System.Drawing.Size(65, 13);
            this.lbl_RollNo.TabIndex = 7;
            this.lbl_RollNo.Text = "Roll Number";
            // 
            // lbl_Mob
            // 
            this.lbl_Mob.AutoSize = true;
            this.lbl_Mob.Location = new System.Drawing.Point(255, 214);
            this.lbl_Mob.Name = "lbl_Mob";
            this.lbl_Mob.Size = new System.Drawing.Size(45, 13);
            this.lbl_Mob.TabIndex = 7;
            this.lbl_Mob.Text = "Mob No";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Location = new System.Drawing.Point(255, 331);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(40, 13);
            this.lbl_Course.TabIndex = 9;
            this.lbl_Course.Text = "Course";
            // 
            // tb_MobNo
            // 
            this.tb_MobNo.Location = new System.Drawing.Point(385, 214);
            this.tb_MobNo.Name = "tb_MobNo";
            this.tb_MobNo.Size = new System.Drawing.Size(141, 20);
            this.tb_MobNo.TabIndex = 3;
            this.tb_MobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Course
            // 
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BSc CS",
            "Chemistry",
            "Physics",
            "Electronic",
            "Micro"});
            this.cmb_Course.Location = new System.Drawing.Point(385, 328);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(141, 21);
            this.cmb_Course.TabIndex = 5;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(255, 272);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(30, 13);
            this.lbl_DOB.TabIndex = 14;
            this.lbl_DOB.Text = "DOB";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(385, 266);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(141, 20);
            this.dtp_DOB.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(673, 33);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 15;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Std_List
            // 
            this.btn_Std_List.Location = new System.Drawing.Point(530, 405);
            this.btn_Std_List.Name = "btn_Std_List";
            this.btn_Std_List.Size = new System.Drawing.Size(75, 23);
            this.btn_Std_List.TabIndex = 16;
            this.btn_Std_List.Text = "Student List";
            this.btn_Std_List.UseVisualStyleBackColor = true;
            this.btn_Std_List.Click += new System.EventHandler(this.btn_Std_List_Click);
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Std_List);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.tb_Std_Name);
            this.Controls.Add(this.tb_MobNo);
            this.Controls.Add(this.tb_RollNo);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Std_Name);
            this.Controls.Add(this.lbl_Mob);
            this.Controls.Add(this.lbl_RollNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_New_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Std_Name;
        private System.Windows.Forms.TextBox tb_RollNo;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Std_Name;
        private System.Windows.Forms.Label lbl_RollNo;
        private System.Windows.Forms.Label lbl_Mob;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_MobNo;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Std_List;
    }
}