using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InformationKeeper
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Program.ShowAuthorization = Program.CycleEnabled = false;
        }

        #region Front End Events
        private void LabelAuthorization_MouseEnter(object sender, EventArgs e) => (sender as Label).ForeColor = (sender as Label).Text == "Закрыть" ? Color.Red : Color.LightSkyBlue;
        private void LabelAuthorization_MouseLeave(object sender, EventArgs e) => (sender as Label).ForeColor = SystemColors.ControlText;

        private void TextBoxData_FocusEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if ((string)textBox.Tag == "Name")
                if (textBox.Text == "Ваше имя...")
                    textBox.Clear();
            if ((string)textBox.Tag == "Password")
            {
                if ((string)PictureBoxEye.Tag == "close")
                    textBox.UseSystemPasswordChar = true;
                if (textBox.Text == "Пароль...")
                    textBox.Clear();
            }
        }

        private void TextBoxData_FocusLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "")
                if ((string)textBox.Tag == "Name")
                    textBox.Text = "Ваше имя...";
                else
                {
                    if ((string)PictureBoxEye.Tag == "open")
                        textBox.UseSystemPasswordChar = false;
                    textBox.Text = "Пароль...";
                }
        }

        private void LabelExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        Point startMovePoint;
        private void Panel_MouseUp(object sender, MouseEventArgs e) => panel1.MouseMove -= Panel_MouseMove;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            startMovePoint = e.Location;
            panel1.MouseMove += Panel_MouseMove;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.Location.X - startMovePoint.X, e.Location.Y - startMovePoint.Y);
            Location = PointToScreen(point);
        }

        private void PictureBoxEye_Click(object sender, EventArgs e)
        {
            if ((string)PictureBoxEye.Tag == "close")
            {
                PictureBoxEye.Image = Properties.Resources.show_on;
                PictureBoxEye.Tag = "open";
                TextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                PictureBoxEye.Image = Properties.Resources.show_off;
                PictureBoxEye.Tag = "close";
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        private void LabelLogin_Click(object sender, EventArgs e)
        {
            Program.ShowLogin = Program.CycleEnabled = true;
            Close();
        }

        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string pass = TextBoxPassword.Text;
            Image avatar = PictureBoxAvatar.Image;
            
            if (!InformationKeeper.NameIsCorrect(name, out string nameMes))
            {
                LabelDataIncorrect.Text = nameMes;
                LabelDataIncorrect.Visible = true;
                return;
            }

            if (!InformationKeeper.PasswordIsCorrect(pass, out string passMes))
            {
                LabelDataIncorrect.Text = passMes;
                LabelDataIncorrect.Visible = true;
                return;
            }

            Account newAccount = new Account(name, pass, avatar);
            InformationKeeper.SaveAccount(newAccount);

            MessageBox.Show($@"Аккаунт ""{newAccount.Name}"" успешно создан!", "Авторизация", MessageBoxButtons.OK);

            InformationKeeper.Current = newAccount;

            Program.ShowMain = Program.CycleEnabled = true;
            Close();
        }

        private void LabelObserv_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Выберите изображение";
            fileDialog.Filter = "Image Files (*.png; *.jpg; *.bmp)|*.png; *.jpg; *.bmp";
            fileDialog.ShowDialog();
            if (File.Exists(fileDialog.FileName))
                PictureBoxAvatar.Image = Image.FromFile(fileDialog.FileName);
        }
    }
}
