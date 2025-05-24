using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackMate.ToDoPages;
using TrackMate.ToDoTabs;
using static TrackMate.ToDoPages.ToDoAddPage;


namespace TrackMate.Forms
{
    public partial class ToDoTab : Form
    {
        public static UserControl currAddpg;
        public ToDoTab()
        {
            InitializeComponent();
        }

        public static ToDoPageControl ToDoPgAdd()
        {
            var childForm = new ToDoPageControl();
            ToDoDeskPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            return (childForm);
        }

        public static void RefreshPgAdd(UserControl childForm)
        {
            if (currAddpg != null)
            {
               ToDoDeskPanel.Controls.Remove(currAddpg);
            }
            currAddpg = childForm;
            ToDoDeskPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
        }

        private void ToDoTab_Shown(object sender, EventArgs e)
        {
            RefreshPgAdd(new ToDoAddPage());
        }

    }
}
