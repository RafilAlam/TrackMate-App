using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrackMate
{
    public partial class TrackMate : Form
    {
        private bool dragging;
        private Button currentButton;
        private Form activeForm;

        public TrackMate()
        {
            InitializeComponent();
        }

        private void DisableButton()
        {
            foreach (Control previousbtn in TabPanel.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(39, 30, 43);
                    previousbtn.ForeColor = Color.FromArgb(119, 110, 123);
                }
            }
        }

        private void ActivateButton(Object btnSender)
        {
            DisableButton();
            Color Backcolor = Color.FromArgb(49, 40, 53);
            Color Forecolor = Color.FromArgb(119, 110, 123);
            currentButton = (Button)btnSender;
            currentButton.BackColor = Backcolor;
            currentButton.ForeColor = Forecolor;
        }

        private void OpenChildForm(Form childForm, Object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close(); 
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.TabContainer.Controls.Add(childForm);
            this.TabContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
        dragging = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                int MouseX = MousePosition.X - (panel2.Size.Width / 2);
                int MouseY = MousePosition.Y - (panel2.Size.Height / 2);
                this.SetDesktopLocation(MouseX, MouseY);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maxbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Counter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CounterTab(), sender);
        }

        private void ToDobtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ToDoTab(), sender);
        }
    }
}
