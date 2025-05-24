using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackMate.Forms;
using static TrackMate.Forms.CounterTab;

namespace TrackMate.CounterPages
{
    public partial class CounterAddPage : UserControl
    {

        public CounterAddPage()
        {
            InitializeComponent();
        }

        public class TabToSave
        { 
            public List<PageToSave> PageList { get; set; }
        }

        public class PageToSave
        {
            public string Title { get; set; }
            public List<string> valueNames { get; set; }
            public List<string> valueValues { get; set; }
        }
        public static void Addbtn_Click(object sender, EventArgs e)
        {
            CounterPgAdd();
            
        }
    }
}
