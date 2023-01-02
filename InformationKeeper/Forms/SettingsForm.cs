using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InformationKeeper
{
    public partial class SettingsForm : Form
    {
        bool changePassword;
        Account account;

        public SettingsForm()
        {
            InitializeComponent();
            account = InformationKeeper.Current;
            TextBoxName.Text = account.Name;
            PictureBoxAvatar.Image = account.Avatar;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Program.CycleEnabled = Program.ShowLogin = Program.ShowAuthorization = Program.ShowMain = false;
            Close();
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string tag = (string)control.Tag;

            if (tag == "close")
                (control as PictureBox).BackColor = Color.FromArgb(224, 224, 224);
            if (tag == "choose avatar")
                (control as Label).ForeColor = Color.LightBlue;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string tag = (string)control.Tag;

            if (tag == "close")
                (control as PictureBox).BackColor = SystemColors.Control;
            if (tag == "choose avatar")
                (control as Label).ForeColor = SystemColors.ControlText;
        }

        private void ButtonNextPassStep_Click(object sender, EventArgs e)
        {
            LabelError.Visible = false;
            if (!changePassword)
                if (TextBoxPassword.Text == account.Password)
                {
                    TextBoxPassword.Clear();
                    TextBoxPassword.Focus();
                    LabelPassStepInfo.Text = "Новый пароль:";
                    ButtonNextPassStep.Enabled = false;
                    changePassword = true;
                }
                else
                {
                    LabelError.Visible = true;
                    LabelError.Text = "Неверно указан старый пароль!";
                }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (changePassword)
                if (!InformationKeeper.PasswordIsCorrect(TextBoxPassword.Text, out string mes))
                {
                    LabelError.Text = mes;
                    LabelError.Visible = true;
                    return;
                }
            if (!InformationKeeper.NameIsCorrect(TextBoxName.Text, out string mes2) && TextBoxName.Text != account.Name)
            {
                LabelError.Text = mes2;
                LabelError.Visible = true;
                return;
            }

            string oldAccountName = account.Name;

            account.Name = TextBoxName.Text;
            if (changePassword)
                account.Password = TextBoxPassword.Text;
            account.Avatar = PictureBoxAvatar.Image;

            InformationKeeper.UpdateAccount(oldAccountName, account);

            (bool, string) oldInfo = InformationKeeper.LoadInfo();
            InformationKeeper.SaveInfo(oldInfo.Item1, account.Name);

            MessageBox.Show("Настройки сохранены!");
            Close();
        }

        private void LabelChooseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Выбирите изображение";
            fileDialog.Filter = "Image Files (*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
            fileDialog.ShowDialog();
            if (File.Exists(fileDialog.FileName))
                PictureBoxAvatar.Image = Image.FromFile(fileDialog.FileName);
        }

        private void LabelRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хототие удалить \nаккаунт и все его данные?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InformationKeeper.RemoveAccount(account);
                Program.ShowLogin = Program.CycleEnabled = true;
                Close();
            }
        }

        private void LabelGoOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход:", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Program.ShowLogin = Program.CycleEnabled = true;
                if (File.Exists(InformationKeeper.InfoFileName))
                    File.Delete(InformationKeeper.InfoFileName);
                Close();
            }
        }
    }
}
