using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TrackMate.Forms.CounterTab;
using static TrackMate.CounterPages.CounterAddPage;
using static TrackMate.CounterPages.CounterRow;

namespace TrackMate.CounterPages
{
    public partial class CounterRow : UserControl
    {
        int changeBy = 50;
        public CounterRow()
        {
            InitializeComponent();
        }

        public static void QuickSave()
        {

            var Tab = CounterDeskPanel;
            var TabClass = new TabToSave();
            TabClass.PageList = new List<PageToSave>();

            foreach (UserControl ChildPage in Tab.Controls.OfType<UserControl>())
            {

                var PageClass = new PageToSave();
                PageClass.valueNames = new List<string>();
                PageClass.valueValues = new List<string>();

                if (ChildPage.Name == "CounterPage")
                {
                    TabClass.PageList.Add(PageClass);
                }
                else
                {
                    continue;
                }

                int indexValue = 0;
                foreach (TextBox Item in ChildPage.Controls.OfType<TextBox>())
                {
                    if (Item.Name == "PageTitle")
                    { PageClass.Title = Item.Text; }
                    else if (Item.Name == "ValueNameTxt")
                    {
                        PageClass.valueNames.Add(Item.Text);
                        PageClass.valueValues.Add(ChildPage.Controls[indexValue].Text);
                    }
                    
                    indexValue++;
                }
                foreach (UserControl Item in ChildPage.Controls.OfType<UserControl>())
                {
                    if (Item.Name == "CounterRow")
                    {
                        PageClass.valueNames.Add(Item.Controls[1].Text);
                        PageClass.valueValues.Add(Item.Controls[0].Text);
                    }
                }
            }

            SaveCounterPage(TabClass);
        }

        private void ValueNameTxt_TextChanged(object sender, EventArgs e)
        {
            QuickSave();
        }

        private void ValueTxt_TextChanged(object sender, EventArgs e)
        {
            QuickSave();
        }
    }
}
