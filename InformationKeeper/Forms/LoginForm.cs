using System;
using System.Drawing;
using System.Windows.Forms;

namespace InformationKeeper
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Program.ShowLogin = Program.CycleEnabled = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var (autoLogin, accountName) = InformationKeeper.LoadInfo(); //AutoLogin
            if (autoLogin)
                if (InformationKeeper.AccountExists((acc) => acc.Name == accountName))
                {
                    InformationKeeper.Current = InformationKeeper.GetAccount((acc) => acc.Name == accountName);
                    Close();
                    Program.ShowMain = true;
                }
        }

        private void LabelAuthorization_Click(object sender, EventArgs e)
        {
            Program.ShowAuthorization = Program.CycleEnabled = true;
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (InformationKeeper.AccountExists((acc) => acc.Name == TextBoxName.Text && acc.Password == TextBoxPassword.Text))
            {
                InformationKeeper.Current = InformationKeeper.GetAccount((acc) => acc.Name == TextBoxName.Text);
                InformationKeeper.SaveInfo(CheckBoxRemember.Checked, TextBoxName.Text);
                Program.ShowMain = Program.CycleEnabled = true;
                Close();
            }
            else
                LabelIncorrectData.Visible = true;
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
        private void Panel_MouseUp(object sender, MouseEventArgs e) =>panel1. MouseMove -= Panel_MouseMove;
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
    }
}
