using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InformationKeeper
{
    partial class DataControl : UserControl
    {
        IData data;
        Account account;
        MainForm form;
        public DataControl(MainForm form, Account account, IData data)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.data = data;
            this.account = account;
            this.form = form;
            if (data is AccountInfo accountInfo)
            {
                LabelDataType.Text = "Информация об уч. записи";
                AddTextBoxAndLabel("Название:", "name", accountInfo.Name, false);
                AddTextBoxAndLabel("Описание:", "description", accountInfo.Description, true);
                AddTextBoxAndLabel("Имя:", "login", (string)accountInfo["login"], false);
                AddTextBoxAndLabel("Пароль:", "password", (string)accountInfo["password"], false);
                AddTextBoxAndLabel("E-mail:", "email", (string)accountInfo["email"], false);
                AddTextBoxAndLabel("Номер телефона:", "number", (string)accountInfo["number"], false);
            }
            else if (data is Note note)
            {
                LabelDataType.Text = "Заметка";
                AddTextBoxAndLabel("Название:", "name", note.Name, false);
                AddTextBoxAndLabel("Описание:", "description", note.Description, true);
                AddTextBoxAndLabel("Содердание:", "content", (string)note["content"], true);
            }
            else if (data is Album album)
            {
                LabelDataType.Text = "Фотоальбом";
                AddTextBoxAndLabel("Название:", "name", album.Name, false);
                AddTextBoxAndLabel("Описание:", "description", album.Description, true);

                Button buttonRemove = new Button { Name = "remove", Text = "Удал. изобр.", FlatStyle = FlatStyle.Flat, Enabled = false, Font = new Font("Tahoma", 7, FontStyle.Regular), Location = new Point(ButtonRemove.Location.X - 180, ButtonRemove.Location.Y), Anchor = AnchorStyles.Bottom | AnchorStyles.Right, Height = 25, Width = 85 };
                buttonRemove.Click += RemovePictureBox_Click;
                Controls.Add(buttonRemove);

                Button buttonAdd = new Button { Name = "add", Text = "Доб. изобр.", FlatStyle = FlatStyle.Flat, Font = new Font("Tahoma", 7, FontStyle.Regular), Location = new Point(ButtonRemove.Location.X - 90, ButtonRemove.Location.Y), Anchor = AnchorStyles.Bottom | AnchorStyles.Right, Height = 25, Width = 85 };
                buttonAdd.Click += (sender, e) => 
                {
                    OpenFileDialog fileDialog = new OpenFileDialog { Title = "Выберите изображение", Filter = "Image Files (*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp" };
                    fileDialog.ShowDialog();
                    if (File.Exists(fileDialog.FileName))
                        PanelInfo.ScrollControlIntoView(AddPictureBox(Image.FromFile(fileDialog.FileName)));
                };
                Controls.Add(buttonAdd);

                foreach (Image image in album["images"] as Image[])
                    AddPictureBox(image);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PanelInfo.Controls["name"].Text) || string.IsNullOrEmpty(PanelInfo.Controls["description"].Text) || InformationKeeper.DataExists(account, (d) => d.Name == PanelInfo.Controls["name"].Text && d.Name != data.Name))
            {
                MessageBox.Show("Укажите имя и описание, имя не должно совпадать с другими", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (data is AccountInfo accountInfo)
            {
                string oldName = PanelInfo.Controls["name"].Text;
                accountInfo.Name = PanelInfo.Controls["name"].Text;
                accountInfo.Description = PanelInfo.Controls["description"].Text;
                accountInfo["login"] = PanelInfo.Controls["login"].Text;
                accountInfo["password"] = PanelInfo.Controls["password"].Text;
                accountInfo["email"] = PanelInfo.Controls["email"].Text;
                accountInfo["number"] = PanelInfo.Controls["number"].Text;
                InformationKeeper.UpdateData(account, oldName, accountInfo);
                form.LoadDataInfo(data);
                form.LoadDataList();
            }
            else if (data is Note note)
            {
                string oldName = PanelInfo.Controls["name"].Text;
                note.Name = PanelInfo.Controls["name"].Text;
                note.Description = PanelInfo.Controls["description"].Text;
                note["content"] = PanelInfo.Controls["content"].Text;
                InformationKeeper.UpdateData(account, oldName, note);
                form.LoadDataInfo(data);
                form.LoadDataList();
            }
            else if(data is Album album)
            {
                string oldName = PanelInfo.Controls["name"].Text;
                album.Name = PanelInfo.Controls["name"].Text;
                album.Description = PanelInfo.Controls["description"].Text;

                List<Image> images = new List<Image>();

                foreach (Control control in PanelInfo.Controls)
                    if (control is PictureBox pictureBox)
                        images.Add((control as PictureBox).Image);

                album["images"] = images.ToArray();

                InformationKeeper.UpdateData(account, oldName, album);
                form.LoadDataInfo(data);
                form.LoadDataList();
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            var list = InformationKeeper.LoadAccounts();
            InformationKeeper.RemoveData(account, data);
            form.Controls["PanelData"].Controls.Remove(this);
            form.LoadDataList();
        }

        PictureBox AddPictureBox(Image image)
        {
            PictureBox pictureBox = new PictureBox { Tag = image, Height = 400, Width = PanelInfo.Controls["name"].Width, Image = image, SizeMode = PictureBoxSizeMode.AutoSize, Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top };
            pictureBox.Click += (sender, e) =>
            {
                foreach (Control control in PanelInfo.Controls)
                    if (control is PictureBox picture)
                        picture.BorderStyle = BorderStyle.None;
                if ((sender as PictureBox).BorderStyle == BorderStyle.None)
                {
                    (sender as PictureBox).BorderStyle = BorderStyle.FixedSingle;
                    Controls["remove"].Enabled = true;
                }
                else
                {
                    (sender as PictureBox).BorderStyle = BorderStyle.None;
                    Controls["remove"].Enabled = false;
                }
            };

            if (pictureBox.Image.Height > 1000 || pictureBox.Image.Width > 1000)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(PanelInfo.Controls["name"].Width, 1000);
            }

            foreach (Control control in PanelInfo.Controls)
                if (control.Location.Y + control.Height > pictureBox.Location.Y)
                    pictureBox.Location = new Point(PanelInfo.Controls["name"].Location.X, control.Location.Y + control.Height + 30);

            PanelInfo.Controls.Add(pictureBox);
            return pictureBox;
        }

        void RemovePictureBox_Click(object sender, EventArgs e)
        {
            foreach (Control control in PanelInfo.Controls)
                if (control is PictureBox picture && picture.BorderStyle == BorderStyle.FixedSingle)
                {
                    int index = PanelInfo.Controls.IndexOf(picture);
                    PanelInfo.Controls.Remove(picture);

                    for (int i = index; i < PanelInfo.Controls.Count; i++)
                        PanelInfo.Controls[i].Location = new Point(PanelInfo.Controls[i].Location.X, PanelInfo.Controls[i].Location.Y - picture.Height - 30);

                    Controls["remove"].Enabled = false;
                    return;
                }
        }

        void AddTextBoxAndLabel(string labelText, string textBoxName, string textBoxText, bool multiLine)
        {
            TextBox textBox = new TextBox { Text = textBoxText, Name = textBoxName, Font = new Font("Tahoma", 9.75F, FontStyle.Regular), BorderStyle = BorderStyle.FixedSingle, BackColor = SystemColors.Control, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, Multiline = multiLine, Height = multiLine ? 112 : 23 };
            Label label = new Label { Text = labelText, Location = new Point(18, 47), Font = new Font("Tahoma", 14.25F, FontStyle.Regular), AutoSize = true };
            foreach (Control control in PanelInfo.Controls)
                if (control.Location.Y + control.Height > label.Location.Y)
                {
                    label.Location = new Point(18, control.Location.Y + control.Height + 47);
                }
            textBox.Tag = label;
            PanelInfo.Controls.AddRange(new Control[] { label, textBox });

            foreach (Control control in PanelInfo.Controls)
                if (control is TextBox)
                {
                    control.Location = new Point((control.Tag as Label).Location.X + (control.Tag as Label).Width + 5, (control.Tag as Label).Location.Y + 3);
                    control.Width = PanelInfo.Width - control.Location.X - 5;
                }
        }
    }
}
