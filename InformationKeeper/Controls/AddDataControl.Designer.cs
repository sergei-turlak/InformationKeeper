namespace InformationKeeper
{
    partial class AddDataControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSave = new System.Windows.Forms.Button();
            this.CheckBoxNote = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxAccountInfo = new System.Windows.Forms.CheckBox();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.LabelDataType = new System.Windows.Forms.Label();
            this.CheckBoxPhotoAlbum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(405, 292);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(137, 40);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Visible = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // CheckBoxNote
            // 
            this.CheckBoxNote.AutoSize = true;
            this.CheckBoxNote.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxNote.Location = new System.Drawing.Point(21, 94);
            this.CheckBoxNote.Name = "CheckBoxNote";
            this.CheckBoxNote.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxNote.TabIndex = 7;
            this.CheckBoxNote.Tag = "note";
            this.CheckBoxNote.Text = "Заметка";
            this.CheckBoxNote.UseVisualStyleBackColor = false;
            this.CheckBoxNote.Click += new System.EventHandler(this.ChangeCheckState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выбирите шаблон:";
            // 
            // CheckBoxAccountInfo
            // 
            this.CheckBoxAccountInfo.AutoSize = true;
            this.CheckBoxAccountInfo.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxAccountInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxAccountInfo.Location = new System.Drawing.Point(21, 74);
            this.CheckBoxAccountInfo.Name = "CheckBoxAccountInfo";
            this.CheckBoxAccountInfo.Size = new System.Drawing.Size(77, 17);
            this.CheckBoxAccountInfo.TabIndex = 5;
            this.CheckBoxAccountInfo.Tag = "account info";
            this.CheckBoxAccountInfo.Text = "Уч. запись";
            this.CheckBoxAccountInfo.UseVisualStyleBackColor = false;
            this.CheckBoxAccountInfo.Click += new System.EventHandler(this.ChangeCheckState_Click);
            // 
            // PanelInfo
            // 
            this.PanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInfo.AutoScroll = true;
            this.PanelInfo.Location = new System.Drawing.Point(143, 49);
            this.PanelInfo.MinimumSize = new System.Drawing.Size(395, 181);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(399, 208);
            this.PanelInfo.TabIndex = 17;
            // 
            // LabelDataType
            // 
            this.LabelDataType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelDataType.AutoSize = true;
            this.LabelDataType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDataType.Location = new System.Drawing.Point(260, 14);
            this.LabelDataType.Name = "LabelDataType";
            this.LabelDataType.Size = new System.Drawing.Size(80, 23);
            this.LabelDataType.TabIndex = 18;
            this.LabelDataType.Text = "Шаблон";
            this.LabelDataType.Visible = false;
            // 
            // CheckBoxPhotoAlbum
            // 
            this.CheckBoxPhotoAlbum.AutoSize = true;
            this.CheckBoxPhotoAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxPhotoAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxPhotoAlbum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBoxPhotoAlbum.Location = new System.Drawing.Point(21, 114);
            this.CheckBoxPhotoAlbum.Name = "CheckBoxPhotoAlbum";
            this.CheckBoxPhotoAlbum.Size = new System.Drawing.Size(85, 17);
            this.CheckBoxPhotoAlbum.TabIndex = 19;
            this.CheckBoxPhotoAlbum.Tag = "album";
            this.CheckBoxPhotoAlbum.Text = "Фотоальбом";
            this.CheckBoxPhotoAlbum.UseVisualStyleBackColor = false;
            this.CheckBoxPhotoAlbum.Click += new System.EventHandler(this.ChangeCheckState_Click);
            // 
            // AddDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.CheckBoxPhotoAlbum);
            this.Controls.Add(this.LabelDataType);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.CheckBoxNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxAccountInfo);
            this.Controls.Add(this.ButtonSave);
            this.MinimumSize = new System.Drawing.Size(465, 320);
            this.Name = "AddDataControl";
            this.Size = new System.Drawing.Size(558, 350);
            this.Tag = "album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.CheckBox CheckBoxNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBoxAccountInfo;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label LabelDataType;
        private System.Windows.Forms.CheckBox CheckBoxPhotoAlbum;
    }
}
