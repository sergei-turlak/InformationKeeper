using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using InformationKeeper.Properties;

namespace InformationKeeper
{
    public partial class MainForm : Form
    {
        Account account;

        public MainForm()
        {
            InitializeComponent();
            Program.ShowMain = Program.CycleEnabled = false;
            LoadAccountInformation();
        }

        private void LoadAccountInformation()
        {
            account = InformationKeeper.Current;

            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, PictureBoxAvatar.Width, PictureBoxAvatar.Height);
            PictureBoxAvatar.Region = new Region(graphics);
            PictureBoxAvatar.Image = account.Avatar;

            LabelName.Text = account.Name;
            new ToolTip { InitialDelay = 10 }.SetToolTip(PictureBoxEscape, "Выход из текущего аккаунта");

            PictureBox avatarBackground = new PictureBox { Location = new Point(PictureBoxAvatar.Location.X - 2, PictureBoxAvatar.Location.Y - 2), Size = new Size(PictureBoxAvatar.Width + 4, PictureBoxAvatar.Height + 4), BackColor = Color.Gray };
            GraphicsPath graphics2 = new GraphicsPath();
            graphics2.AddEllipse(0, 0, avatarBackground.Width, avatarBackground.Height);
            avatarBackground.Region = new Region(graphics2);
            Controls.Add(avatarBackground);
            avatarBackground.SendToBack();

            LoadDataList();
            PanelData.Controls.Add(new AddDataControl(account, this) { Dock = DockStyle.Fill });
            PictureBoxIncreaseDecrease_Click(null, null);
        }

        public void LoadDataList()
        {
            PanelList.Controls.Clear();

            foreach (var data in account.Data)
            {
                Label item = new Label { AutoSize = false, Width = PanelList.Width - 19, Tag = "item", Font = new Font("Tahoma", 10, FontStyle.Regular), Text = data.Name };
                foreach (Control control in PanelList.Controls)
                    if ((string)control.Tag == "item")
                        item.Location = new Point(0, control.Location.Y + control.Height);
                item.MouseEnter += Control_MouseEnter;
                item.MouseLeave += Control_MouseLeave;
                item.Click += Data_Click;
                new ToolTip().SetToolTip(item, $"Название: {data.Name}\r\nОписание: {data.Description}");
                PanelList.Controls.Add(item);
            }

            if (account.Data.Count == 0)
            {
                PanelList.Controls.Add(LabelTip);
                PanelList.Controls.Add(PictureBoxLogo);
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            LoadDataInfo(InformationKeeper.GetData(account, (data) => data.Name == (sender as Label).Text));
        }

        public void LoadDataInfo(IData data)
        {
            PanelData.Controls.Clear();
            DataControl control = new DataControl(this, account, data);
            PanelData.Controls.Add(control);
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            PanelData.Controls.Clear();
            PanelData.Controls.Add(new AddDataControl(account, this) { Dock = DockStyle.Fill });
        }


        private void PictureBoxAvatar_Click(object sender, EventArgs e)
        {
            Opacity = 0.8;
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            LabelName.Text = account.Name;
            PictureBoxAvatar.Image = account.Avatar;
            Opacity = 1.0;
            if (Program.ShowLogin)
                Close();
        }

        private void PictureBoxEscape_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход:", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Program.ShowLogin = Program.CycleEnabled = true;
                if (File.Exists(InformationKeeper.InfoFileName))
                    File.Delete(InformationKeeper.InfoFileName);
                Close();
            }
        }

        #region Front End Events    

        enum CursorState
        {
            Default, Resizable, Vertical, Horizontal
        }

        CursorState cursorMove = CursorState.Default;

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBoxIncreaseDecrease.Image = Properties.Resources.increase;
            PictureBoxIncreaseDecrease.Tag = "increase";
            WindowState = FormWindowState.Normal;

            if (cursorMove == CursorState.Resizable)
            {
                startMovePoint = e.Location;
                MouseMove += MouseMove_MoveForm;
                return;
            }
            cursorResize = cursorMove;
            MouseMove += MouseMove_ResizeForm;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMove -= MouseMove_MoveForm;
            MouseMove -= MouseMove_ResizeForm;
        }

        Point startMovePoint;
        private void MouseMove_MoveForm(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.Location.X - startMovePoint.X, e.Location.Y - startMovePoint.Y);
            Location = PointToScreen(point);
        }

        CursorState cursorResize = CursorState.Horizontal;
        private void MouseMove_ResizeForm(object sender, MouseEventArgs e)
        {
            if (cursorResize == CursorState.Horizontal)
                Width = e.X;
            else if (cursorResize == CursorState.Vertical)
                Height = e.Y;
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            cursorMove = CursorState.Default;
            Cursor = Cursors.Default;
        }

        private void MouseMoveCursorChange(object sender, MouseEventArgs e)
        {
            int offset = 5;
            if (e.X > Width - offset)
            {
                Cursor = Cursors.SizeWE;
                cursorMove = CursorState.Horizontal;
            }
            else if (e.Y > Height - offset)
            {
                Cursor = Cursors.SizeNS;
                cursorMove = CursorState.Vertical;
            }
            else if (e.Y < 33)
            {
                Cursor = Cursors.Default;
                cursorMove = CursorState.Resizable;
            }
            else
            {
                Cursor = Cursors.Default;
                cursorMove = CursorState.Default;
            }
        }

        private void PictureBoxIncreaseDecrease_Click(object sender, EventArgs e)
        {
            if ((string)PictureBoxIncreaseDecrease.Tag == "increase")
            {
                PictureBoxIncreaseDecrease.Image = Properties.Resources.decrease;
                PictureBoxIncreaseDecrease.Tag = "decrease";
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                PictureBoxIncreaseDecrease.Image = Properties.Resources.increase;
                PictureBoxIncreaseDecrease.Tag = "increase";
                WindowState = FormWindowState.Normal;
            }
        }

        private void PictureBoxRollUp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string tag = (string)control.Tag;

            if (tag == "close" || tag == "roll up" || tag == "increase" || tag == "decrease")
                (control as PictureBox).BackColor = Color.FromArgb(224, 224, 224);
            else if (tag == "settings")
                (control as PictureBox).Image = Resources.settings;
            else if (tag == "add data")
                (control as PictureBox).Image = Resources.add2;
            else if (tag == "item")
                (control as Label).ForeColor = Color.LightSkyBlue;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            string tag = (string)control.Tag;

            if (tag == "close" || tag == "roll up" || tag == "increase" || tag == "decrease")
                (control as PictureBox).BackColor = Color.LightGray;
            else if (tag == "settings")
                (control as PictureBox).Image = account.Avatar;
            else if (tag == "add data")
                (control as PictureBox).Image = Resources.add1;
            else if (tag == "item")
                (control as Label).ForeColor = SystemColors.ControlText;
        }
        #endregion                  
    }
}