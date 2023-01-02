namespace InformationKeeper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.PictureBoxExit = new System.Windows.Forms.PictureBox();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassStepInfo = new System.Windows.Forms.Label();
            this.ButtonNextPassStep = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.LabelChooseAvatar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelRemove = new System.Windows.Forms.Label();
            this.LabelGoOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxExit
            // 
            this.PictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxExit.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxExit.Image")));
            this.PictureBoxExit.Location = new System.Drawing.Point(535, 0);
            this.PictureBoxExit.Name = "PictureBoxExit";
            this.PictureBoxExit.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxExit.TabIndex = 7;
            this.PictureBoxExit.TabStop = false;
            this.PictureBoxExit.Tag = "close";
            this.PictureBoxExit.Click += new System.EventHandler(this.Close_Click);
            this.PictureBoxExit.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PictureBoxExit.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Location = new System.Drawing.Point(-2, 0);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(552, 162);
            this.PictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAvatar.TabIndex = 8;
            this.PictureBoxAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(371, 302);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(167, 36);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxName.Location = new System.Drawing.Point(62, 172);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 23);
            this.TextBoxName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Смена пароля:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPassword.Location = new System.Drawing.Point(6, 252);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.TextBoxPassword.TabIndex = 13;
            this.TextBoxPassword.Tag = "old pass";
            // 
            // LabelPassStepInfo
            // 
            this.LabelPassStepInfo.AutoSize = true;
            this.LabelPassStepInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassStepInfo.Location = new System.Drawing.Point(5, 236);
            this.LabelPassStepInfo.Name = "LabelPassStepInfo";
            this.LabelPassStepInfo.Size = new System.Drawing.Size(89, 13);
            this.LabelPassStepInfo.TabIndex = 14;
            this.LabelPassStepInfo.Text = "Старый пароль:";
            // 
            // ButtonNextPassStep
            // 
            this.ButtonNextPassStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNextPassStep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextPassStep.Location = new System.Drawing.Point(44, 278);
            this.ButtonNextPassStep.Name = "ButtonNextPassStep";
            this.ButtonNextPassStep.Size = new System.Drawing.Size(62, 24);
            this.ButtonNextPassStep.TabIndex = 15;
            this.ButtonNextPassStep.Text = "Далее";
            this.ButtonNextPassStep.UseVisualStyleBackColor = true;
            this.ButtonNextPassStep.Click += new System.EventHandler(this.ButtonNextPassStep_Click);
            // 
            // LabelError
            // 
            this.LabelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(5, 323);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(360, 15);
            this.LabelError.TabIndex = 16;
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelError.Visible = false;
            // 
            // LabelChooseAvatar
            // 
            this.LabelChooseAvatar.AutoSize = true;
            this.LabelChooseAvatar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChooseAvatar.Location = new System.Drawing.Point(458, 179);
            this.LabelChooseAvatar.Name = "LabelChooseAvatar";
            this.LabelChooseAvatar.Size = new System.Drawing.Size(80, 13);
            this.LabelChooseAvatar.TabIndex = 17;
            this.LabelChooseAvatar.Tag = "choose avatar";
            this.LabelChooseAvatar.Text = "выбрать файл";
            this.LabelChooseAvatar.Click += new System.EventHandler(this.LabelChooseAvatar_Click);
            this.LabelChooseAvatar.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.LabelChooseAvatar.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(367, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Аватарка:";
            // 
            // LabelRemove
            // 
            this.LabelRemove.AutoSize = true;
            this.LabelRemove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRemove.ForeColor = System.Drawing.Color.Red;
            this.LabelRemove.Location = new System.Drawing.Point(442, 236);
            this.LabelRemove.Name = "LabelRemove";
            this.LabelRemove.Size = new System.Drawing.Size(96, 13);
            this.LabelRemove.TabIndex = 19;
            this.LabelRemove.Tag = "choose avatar";
            this.LabelRemove.Text = "Удалить аккаунт";
            this.LabelRemove.Click += new System.EventHandler(this.LabelRemove_Click);
            // 
            // LabelGoOut
            // 
            this.LabelGoOut.AutoSize = true;
            this.LabelGoOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGoOut.ForeColor = System.Drawing.Color.Red;
            this.LabelGoOut.Location = new System.Drawing.Point(499, 218);
            this.LabelGoOut.Name = "LabelGoOut";
            this.LabelGoOut.Size = new System.Drawing.Size(39, 13);
            this.LabelGoOut.TabIndex = 20;
            this.LabelGoOut.Tag = "choose avatar";
            this.LabelGoOut.Text = "Выйти";
            this.LabelGoOut.Click += new System.EventHandler(this.LabelGoOut_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.LabelGoOut);
            this.Controls.Add(this.LabelRemove);
            this.Controls.Add(this.LabelChooseAvatar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.ButtonNextPassStep);
            this.Controls.Add(this.LabelPassStepInfo);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PictureBoxExit);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBoxExit;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassStepInfo;
        private System.Windows.Forms.Button ButtonNextPassStep;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.Label LabelChooseAvatar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelRemove;
        private System.Windows.Forms.Label LabelGoOut;
    }
}