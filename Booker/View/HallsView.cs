using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpf.Core;
using Booker.Model;
using Booker.Helper;

namespace Booker.View
{
    public partial class HallsView : DevExpress.XtraBars.Ribbon.RibbonForm
    {        

        private BindingList<Hall> hallsList;
        public HallsView()
        {
            InitializeComponent();
            hallsList = new BindingList<Hall>(DataHelper.LoadHalls());
            gridControl.DataSource = hallsList;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataHelper.SaveHalls(new List<Hall>(hallsList));
        }

        
    }
}
