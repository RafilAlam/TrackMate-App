using DynamicData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackMate.CounterPages;
using static TrackMate.CounterPages.CounterAddPage;

namespace TrackMate.Forms
{
    public partial class CounterTab : Form
    {
        public static UserControl currAddpg;

        public CounterTab()
        {
            InitializeComponent();
        }

        static bool CanSave = true; 

        public static void RefreshPgAdd(UserControl childForm)
        {
            if (currAddpg != null)
            {
                CounterDeskPanel.Controls.Remove(currAddpg);
            }
            currAddpg = childForm;
            CounterDeskPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public static CounterPage CounterPgAdd()
        {
            var childForm = new CounterPage();
            CounterDeskPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            return (childForm);
        }

        public static void SaveCounterPage(TabToSave TabClass)
        {
            if (CanSave == true)
            {
                var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(TabClass, Newtonsoft.Json.Formatting.Indented);

                string Docpath = null;

                Docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                string filepath = Path.Combine(Docpath, "CounterData.txt");

                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.Write(serializedObject);
                }

                string content = null;

                using (StreamReader sr = new StreamReader(filepath))
                {
                    content = sr.ReadToEnd();
                }
                var deserializedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<TabToSave>(content);
            }
        }

        public static void ReconstructCounterPages()
        {
            CanSave = false;
            string Docpath = null;

            Docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filepath = Path.Combine(Docpath, "CounterData.txt");

            string content = null;

            using (StreamReader sr = new StreamReader(filepath))
            {
                content = sr.ReadToEnd();
            }
            var deserializedData = Newtonsoft.Json.JsonConvert.DeserializeObject<TabToSave>(content);
            if (deserializedData != null)
            {
                foreach (var PageData in deserializedData.PageList)
                {
                    var Page = CounterPgAdd();
                    var iValue = 0;
                    foreach (TextBox TBox in Page.Controls.OfType<TextBox>())
                    {
                        if (TBox.Name == "PageTitle")
                        {
                            TBox.Text = PageData.Title;
                        }
                        else if (TBox.Name == "ValueNameTxt")
                        {
                            TBox.Text = PageData.valueNames[iValue];
                            iValue++;
                        }
                        else if (TBox.Name == "ValueTxt")
                        {
                            TBox.Text = PageData.valueValues[iValue];
                        }
                    }
                if (PageData.valueNames.Count > iValue)
                    {
                        for (int i = iValue; i < PageData.valueNames.Count; i++)
                        {
                            int changeBy = 50;
                            var AddRowBtn = Page.Controls[0];
                            Page.Height += changeBy;
                            var NewRow = new CounterRow();
                            Page.Controls.Add(NewRow);
                            NewRow.Location = new Point(0, Page.Height - NewRow.Height - changeBy);
                            AddRowBtn.Location = new Point(AddRowBtn.Location.X, Page.Height - AddRowBtn.Height - (changeBy / 2));
                            NewRow.Controls[1].Text = PageData.valueNames[i];
                            NewRow.Controls[0].Text = PageData.valueValues[i];
                        }
                    }



                }
            }
            CanSave = true;
            
        }

        private void CounterTab_Shown(object sender, EventArgs e)
        {
            RefreshPgAdd(new CounterPages.CounterAddPage());
            ReconstructCounterPages();
        }
    }
}
