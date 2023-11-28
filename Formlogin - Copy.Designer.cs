namespace hoadonnhap
{
    partial class Formlogin
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btxoa = new System.Windows.Forms.Button();
            this.btdangki = new System.Windows.Forms.Button();
            this.phanhoi = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rabt3 = new System.Windows.Forms.RadioButton();
            this.rabt2 = new System.Windows.Forms.RadioButton();
            this.rabt1 = new System.Windows.Forms.RadioButton();
            this.txtpassword = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(255, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "show pass";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.Color.SlateBlue;
            this.btlogin.Location = new System.Drawing.Point(126, 522);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(123, 38);
            this.btlogin.TabIndex = 27;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(23, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tỉnh/Thành phố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gửi phản hồi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "you have acount";
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.ForeColor = System.Drawing.Color.White;
            this.btxoa.Location = new System.Drawing.Point(76, 446);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(219, 34);
            this.btxoa.TabIndex = 21;
            this.btxoa.Text = "CLEAR";
            this.btxoa.UseVisualStyleBackColor = false;
            // 
            // btdangki
            // 
            this.btdangki.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btdangki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdangki.ForeColor = System.Drawing.Color.White;
            this.btdangki.Location = new System.Drawing.Point(76, 389);
            this.btdangki.Name = "btdangki";
            this.btdangki.Size = new System.Drawing.Size(219, 34);
            this.btdangki.TabIndex = 20;
            this.btdangki.Text = "REGISTER";
            this.btdangki.UseVisualStyleBackColor = false;
            this.btdangki.Click += new System.EventHandler(this.btdangki_Click);
            // 
            // phanhoi
            // 
            this.phanhoi.FormattingEnabled = true;
            this.phanhoi.Location = new System.Drawing.Point(25, 277);
            this.phanhoi.Name = "phanhoi";
            this.phanhoi.Size = new System.Drawing.Size(308, 95);
            this.phanhoi.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hà Nội",
            "Thái Bình",
            "..."});
            this.comboBox1.Location = new System.Drawing.Point(25, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // rabt3
            // 
            this.rabt3.AutoSize = true;
            this.rabt3.Location = new System.Drawing.Point(248, 182);
            this.rabt3.Name = "rabt3";
            this.rabt3.Size = new System.Drawing.Size(53, 17);
            this.rabt3.TabIndex = 17;
            this.rabt3.Text = "Thứ 3";
            this.rabt3.UseVisualStyleBackColor = true;
            // 
            // rabt2
            // 
            this.rabt2.AutoSize = true;
            this.rabt2.Location = new System.Drawing.Point(126, 182);
            this.rabt2.Name = "rabt2";
            this.rabt2.Size = new System.Drawing.Size(47, 17);
            this.rabt2.TabIndex = 16;
            this.rabt2.Text = "Nam";
            this.rabt2.UseVisualStyleBackColor = true;
            // 
            // rabt1
            // 
            this.rabt1.AutoSize = true;
            this.rabt1.Checked = true;
            this.rabt1.Location = new System.Drawing.Point(25, 182);
            this.rabt1.Name = "rabt1";
            this.rabt1.Size = new System.Drawing.Size(39, 17);
            this.rabt1.TabIndex = 15;
            this.rabt1.TabStop = true;
            this.rabt1.Text = "Nữ";
            this.rabt1.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtpassword.Location = new System.Drawing.Point(22, 110);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(53, 13);
            this.txtpassword.TabIndex = 12;
            this.txtpassword.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.AllowDrop = true;
            this.txtuser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Location = new System.Drawing.Point(25, 70);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(310, 20);
            this.txtuser.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Get Started";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btlogin);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btdangki);
            this.groupBox1.Controls.Add(this.phanhoi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rabt3);
            this.groupBox1.Controls.Add(this.rabt2);
            this.groupBox1.Controls.Add(this.rabt1);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 566);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 749);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formlogin";
            this.Text = "Formlogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btdangki;
        private System.Windows.Forms.ListBox phanhoi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rabt3;
        private System.Windows.Forms.RadioButton rabt2;
        private System.Windows.Forms.RadioButton rabt1;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}