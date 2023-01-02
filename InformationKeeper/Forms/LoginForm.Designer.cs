namespace InformationKeeper
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.LabelAuthorization = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.CheckBoxRemember = new System.Windows.Forms.CheckBox();
            this.LabelExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBoxEye = new System.Windows.Forms.PictureBox();
            this.LabelIncorrectData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEye)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.ButtonLogin.Location = new System.Drawing.Point(1, 320);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(248, 52);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // LabelAuthorization
            // 
            this.LabelAuthorization.AutoSize = true;
            this.LabelAuthorization.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuthorization.Location = new System.Drawing.Point(-2, 375);
            this.LabelAuthorization.Name = "LabelAuthorization";
            this.LabelAuthorization.Size = new System.Drawing.Size(216, 13);
            this.LabelAuthorization.TabIndex = 1;
            this.LabelAuthorization.Text = "Нет аккаунта? Вы можете его создать...";
            this.LabelAuthorization.Click += new System.EventHandler(this.LabelAuthorization_Click);
            this.LabelAuthorization.MouseEnter += new System.EventHandler(this.LabelAuthorization_MouseEnter);
            this.LabelAuthorization.MouseLeave += new System.EventHandler(this.LabelAuthorization_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.Location = new System.Drawing.Point(1, 241);
            this.TextBoxName.MaxLength = 25;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(248, 23);
            this.TextBoxName.TabIndex = 3;
            this.TextBoxName.Tag = "Name";
            this.TextBoxName.Text = "Ваше имя...";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxData_FocusEnter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxData_FocusLeave);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(1, 263);
            this.TextBoxPassword.MaxLength = 25;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(228, 23);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.Tag = "Password";
            this.TextBoxPassword.Text = "Пароль...";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxData_FocusEnter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxData_FocusLeave);
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.AutoSize = true;
            this.CheckBoxRemember.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxRemember.Location = new System.Drawing.Point(172, 289);
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxRemember.TabIndex = 6;
            this.CheckBoxRemember.Text = "Запомнить";
            this.CheckBoxRemember.UseVisualStyleBackColor = true;
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExit.Location = new System.Drawing.Point(-2, 388);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(51, 13);
            this.LabelExit.TabIndex = 7;
            this.LabelExit.Text = "Закрыть";
            this.LabelExit.Click += new System.EventHandler(this.LabelExit_Click);
            this.LabelExit.MouseEnter += new System.EventHandler(this.LabelAuthorization_MouseEnter);
            this.LabelExit.MouseLeave += new System.EventHandler(this.LabelAuthorization_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PictureBoxEye);
            this.panel2.Controls.Add(this.LabelExit);
            this.panel2.Controls.Add(this.ButtonLogin);
            this.panel2.Controls.Add(this.CheckBoxRemember);
            this.panel2.Controls.Add(this.LabelAuthorization);
            this.panel2.Controls.Add(this.LabelIncorrectData);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TextBoxPassword);
            this.panel2.Controls.Add(this.TextBoxName);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(32, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 401);
            this.panel2.TabIndex = 8;
            // 
            // PictureBoxEye
            // 
            this.PictureBoxEye.Image = global::InformationKeeper.Properties.Resources.show_off;
            this.PictureBoxEye.Location = new System.Drawing.Point(230, 264);
            this.PictureBoxEye.Name = "PictureBoxEye";
            this.PictureBoxEye.Size = new System.Drawing.Size(20, 23);
            this.PictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEye.TabIndex = 8;
            this.PictureBoxEye.TabStop = false;
            this.PictureBoxEye.Tag = "close";
            this.PictureBoxEye.Click += new System.EventHandler(this.PictureBoxEye_Click);
            // 
            // LabelIncorrectData
            // 
            this.LabelIncorrectData.AutoSize = true;
            this.LabelIncorrectData.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIncorrectData.ForeColor = System.Drawing.Color.Red;
            this.LabelIncorrectData.Location = new System.Drawing.Point(90, 304);
            this.LabelIncorrectData.Name = "LabelIncorrectData";
            this.LabelIncorrectData.Size = new System.Drawing.Size(165, 13);
            this.LabelIncorrectData.TabIndex = 5;
            this.LabelIncorrectData.Text = "Неправильное имя или пароль!";
            this.LabelIncorrectData.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 433);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.CheckBox CheckBoxRemember;
        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LabelAuthorization;
        private System.Windows.Forms.Label LabelIncorrectData;
        private System.Windows.Forms.PictureBox PictureBoxEye;
        private System.Windows.Forms.Panel panel1;
    }
}