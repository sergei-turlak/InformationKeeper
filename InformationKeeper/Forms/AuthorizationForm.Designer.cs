namespace InformationKeeper
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.ButtonAuthorization = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelDataIncorrect = new System.Windows.Forms.Label();
            this.LabelExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBoxEye = new System.Windows.Forms.PictureBox();
            this.LabelObserv = new System.Windows.Forms.Label();
            this.LabelAvatar = new System.Windows.Forms.Label();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAuthorization
            // 
            this.ButtonAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuthorization.Font = new System.Drawing.Font("Tahoma", 15.25F);
            this.ButtonAuthorization.Location = new System.Drawing.Point(1, 133);
            this.ButtonAuthorization.Name = "ButtonAuthorization";
            this.ButtonAuthorization.Size = new System.Drawing.Size(248, 37);
            this.ButtonAuthorization.TabIndex = 0;
            this.ButtonAuthorization.Text = "Авторизоваться";
            this.ButtonAuthorization.UseVisualStyleBackColor = true;
            this.ButtonAuthorization.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(-2, 173);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(103, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Выполнить вход...";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            this.LabelLogin.MouseEnter += new System.EventHandler(this.LabelAuthorization_MouseEnter);
            this.LabelLogin.MouseLeave += new System.EventHandler(this.LabelAuthorization_MouseLeave);
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.Location = new System.Drawing.Point(1, 10);
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
            this.TextBoxPassword.Location = new System.Drawing.Point(1, 32);
            this.TextBoxPassword.MaxLength = 25;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(228, 23);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.Tag = "Password";
            this.TextBoxPassword.Text = "Пароль...";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxData_FocusEnter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxData_FocusLeave);
            // 
            // LabelDataIncorrect
            // 
            this.LabelDataIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.LabelDataIncorrect.ForeColor = System.Drawing.Color.Red;
            this.LabelDataIncorrect.Location = new System.Drawing.Point(0, 56);
            this.LabelDataIncorrect.Name = "LabelDataIncorrect";
            this.LabelDataIncorrect.Size = new System.Drawing.Size(246, 13);
            this.LabelDataIncorrect.TabIndex = 5;
            this.LabelDataIncorrect.Text = "Неправильное имя или пароль!";
            this.LabelDataIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelDataIncorrect.Visible = false;
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExit.Location = new System.Drawing.Point(-2, 186);
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
            this.panel2.Controls.Add(this.LabelObserv);
            this.panel2.Controls.Add(this.LabelAvatar);
            this.panel2.Controls.Add(this.PictureBoxAvatar);
            this.panel2.Controls.Add(this.LabelExit);
            this.panel2.Controls.Add(this.ButtonAuthorization);
            this.panel2.Controls.Add(this.LabelLogin);
            this.panel2.Controls.Add(this.LabelDataIncorrect);
            this.panel2.Controls.Add(this.TextBoxPassword);
            this.panel2.Controls.Add(this.TextBoxName);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(21, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 214);
            this.panel2.TabIndex = 8;
            // 
            // PictureBoxEye
            // 
            this.PictureBoxEye.Image = global::InformationKeeper.Properties.Resources.show_off;
            this.PictureBoxEye.Location = new System.Drawing.Point(230, 33);
            this.PictureBoxEye.Name = "PictureBoxEye";
            this.PictureBoxEye.Size = new System.Drawing.Size(20, 23);
            this.PictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEye.TabIndex = 11;
            this.PictureBoxEye.TabStop = false;
            this.PictureBoxEye.Tag = "close";
            this.PictureBoxEye.Click += new System.EventHandler(this.PictureBoxEye_Click);
            // 
            // LabelObserv
            // 
            this.LabelObserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelObserv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelObserv.Location = new System.Drawing.Point(41, 101);
            this.LabelObserv.Name = "LabelObserv";
            this.LabelObserv.Size = new System.Drawing.Size(49, 13);
            this.LabelObserv.TabIndex = 10;
            this.LabelObserv.Text = "Обзор..";
            this.LabelObserv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelObserv.Click += new System.EventHandler(this.LabelObserv_Click);
            // 
            // LabelAvatar
            // 
            this.LabelAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAvatar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelAvatar.Location = new System.Drawing.Point(-1, 69);
            this.LabelAvatar.Name = "LabelAvatar";
            this.LabelAvatar.Size = new System.Drawing.Size(61, 13);
            this.LabelAvatar.TabIndex = 9;
            this.LabelAvatar.Text = "Аватарка:";
            this.LabelAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAvatar.Image")));
            this.PictureBoxAvatar.Location = new System.Drawing.Point(0, 82);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(42, 32);
            this.PictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAvatar.TabIndex = 8;
            this.PictureBoxAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 283);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 283);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAuthorization;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelDataIncorrect;
        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelAvatar;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Label LabelObserv;
        private System.Windows.Forms.PictureBox PictureBoxEye;
        private System.Windows.Forms.Panel panel1;
    }
}