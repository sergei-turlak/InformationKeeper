namespace InformationKeeper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelList = new System.Windows.Forms.Panel();
            this.PictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureBoxIncreaseDecrease = new System.Windows.Forms.PictureBox();
            this.PictureBoxRollUp = new System.Windows.Forms.PictureBox();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.PictureBoxExit = new System.Windows.Forms.PictureBox();
            this.PictureBoxEscape = new System.Windows.Forms.PictureBox();
            this.PanelData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTip = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIncreaseDecrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEscape)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelList
            // 
            this.PanelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelList.AutoScroll = true;
            this.PanelList.BackColor = System.Drawing.SystemColors.Control;
            this.PanelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelList.Controls.Add(this.PictureBoxLogo);
            this.PanelList.Controls.Add(this.LabelTip);
            this.PanelList.Location = new System.Drawing.Point(3, 40);
            this.PanelList.Name = "PanelList";
            this.PanelList.Size = new System.Drawing.Size(248, 518);
            this.PanelList.TabIndex = 0;
            // 
            // PictureBoxAdd
            // 
            this.PictureBoxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAdd.Image")));
            this.PictureBoxAdd.Location = new System.Drawing.Point(208, 1);
            this.PictureBoxAdd.Name = "PictureBoxAdd";
            this.PictureBoxAdd.Size = new System.Drawing.Size(37, 31);
            this.PictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAdd.TabIndex = 8;
            this.PictureBoxAdd.TabStop = false;
            this.PictureBoxAdd.Tag = "add data";
            this.PictureBoxAdd.Click += new System.EventHandler(this.PictureBoxAdd_Click);
            this.PictureBoxAdd.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PictureBoxAdd.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelName.Location = new System.Drawing.Point(44, 22);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(30, 13);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Имя";
            // 
            // PictureBoxIncreaseDecrease
            // 
            this.PictureBoxIncreaseDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxIncreaseDecrease.BackColor = System.Drawing.Color.LightGray;
            this.PictureBoxIncreaseDecrease.Image = global::InformationKeeper.Properties.Resources.increase;
            this.PictureBoxIncreaseDecrease.Location = new System.Drawing.Point(817, 0);
            this.PictureBoxIncreaseDecrease.Name = "PictureBoxIncreaseDecrease";
            this.PictureBoxIncreaseDecrease.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxIncreaseDecrease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxIncreaseDecrease.TabIndex = 6;
            this.PictureBoxIncreaseDecrease.TabStop = false;
            this.PictureBoxIncreaseDecrease.Tag = "increase";
            this.PictureBoxIncreaseDecrease.Click += new System.EventHandler(this.PictureBoxIncreaseDecrease_Click);
            this.PictureBoxIncreaseDecrease.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PictureBoxIncreaseDecrease.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // PictureBoxRollUp
            // 
            this.PictureBoxRollUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxRollUp.BackColor = System.Drawing.Color.LightGray;
            this.PictureBoxRollUp.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxRollUp.Image")));
            this.PictureBoxRollUp.Location = new System.Drawing.Point(802, 0);
            this.PictureBoxRollUp.Name = "PictureBoxRollUp";
            this.PictureBoxRollUp.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxRollUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRollUp.TabIndex = 5;
            this.PictureBoxRollUp.TabStop = false;
            this.PictureBoxRollUp.Tag = "roll up";
            this.PictureBoxRollUp.Click += new System.EventHandler(this.PictureBoxRollUp_Click);
            this.PictureBoxRollUp.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PictureBoxRollUp.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Location = new System.Drawing.Point(3, 2);
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.Size = new System.Drawing.Size(38, 32);
            this.PictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAvatar.TabIndex = 2;
            this.PictureBoxAvatar.TabStop = false;
            this.PictureBoxAvatar.Tag = "settings";
            this.PictureBoxAvatar.Click += new System.EventHandler(this.PictureBoxAvatar_Click);
            this.PictureBoxAvatar.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PictureBoxAvatar.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // PictureBoxExit
            // 
            this.PictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxExit.BackColor = System.Drawing.Color.LightGray;
            this.PictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxExit.Image")));
            this.PictureBoxExit.Location = new System.Drawing.Point(832, 0);
            this.PictureBoxExit.Name = "PictureBoxExit";
            this.PictureBoxExit.Size = new System.Drawing.Size(15, 15);
            this.PictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxExit.TabIndex = 0;
            this.PictureBoxExit.TabStop = false;
            this.PictureBoxExit.Tag = "close";
            this.PictureBoxExit.Click += new System.EventHandler(this.Close_Click);
            this.PictureBoxExit.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.PictureBoxExit.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // PictureBoxEscape
            // 
            this.PictureBoxEscape.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxEscape.Image")));
            this.PictureBoxEscape.Location = new System.Drawing.Point(45, 0);
            this.PictureBoxEscape.Name = "PictureBoxEscape";
            this.PictureBoxEscape.Size = new System.Drawing.Size(29, 23);
            this.PictureBoxEscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEscape.TabIndex = 7;
            this.PictureBoxEscape.TabStop = false;
            this.PictureBoxEscape.Click += new System.EventHandler(this.PictureBoxEscape_Click);
            // 
            // PanelData
            // 
            this.PanelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelData.BackColor = System.Drawing.SystemColors.Control;
            this.PanelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelData.Location = new System.Drawing.Point(251, 40);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(591, 551);
            this.PanelData.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PictureBoxAdd);
            this.panel1.Location = new System.Drawing.Point(3, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 34);
            this.panel1.TabIndex = 8;
            // 
            // LabelTip
            // 
            this.LabelTip.AutoSize = true;
            this.LabelTip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTip.Location = new System.Drawing.Point(33, 66);
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new System.Drawing.Size(184, 26);
            this.LabelTip.TabIndex = 0;
            this.LabelTip.Text = "Здесь будут показанны заголовки\r\nпосле добавления информации.";
            this.LabelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(17, 95);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(214, 259);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 1;
            this.PictureBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(847, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelList);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PictureBoxEscape);
            this.Controls.Add(this.PictureBoxIncreaseDecrease);
            this.Controls.Add(this.PictureBoxRollUp);
            this.Controls.Add(this.PictureBoxAvatar);
            this.Controls.Add(this.PanelData);
            this.Controls.Add(this.PictureBoxExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(558, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveCursorChange);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.PanelList.ResumeLayout(false);
            this.PanelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIncreaseDecrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEscape)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxExit;
        private System.Windows.Forms.Panel PanelList;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox PictureBoxRollUp;
        private System.Windows.Forms.PictureBox PictureBoxIncreaseDecrease;
        private System.Windows.Forms.PictureBox PictureBoxEscape;
        private System.Windows.Forms.PictureBox PictureBoxAdd;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTip;
    }
}

