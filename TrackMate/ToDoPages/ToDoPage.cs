using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TrackMate.ToDoTabs
{
    public partial class ToDoPageControl : UserControl
    {
        public ToDoPageControl()
        {
            InitializeComponent();
        }
        bool Expanded = false;

        private void ExpandButton_Click(object sender, EventArgs e)
        {
            if (Expanded==false)
            {
                Expanded = true;

                MainPanel.Parent.Size = MainPanel.Size;
            }
            else if (Expanded==true) 
            {
                Expanded = false;

                MainPanel.Parent.Height = 248;
                MainPanel.Parent.Width = 366;
            }
        }

        private void MainPanel_ParentChanged(object sender, EventArgs e)
        {
            var CurrTime = DateTime.Now;
            CreatedOnDate.Text = CurrTime.ToString("dd/M/y hh:mm tt");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MainPanel.Parent.Dispose();
        }
    }
}
