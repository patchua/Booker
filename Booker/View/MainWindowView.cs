using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booker.Helper;
using Booker.Model;
using DevExpress.XtraBars.Docking2010.Views;

namespace Booker.View
{
    public partial class MainWindowView : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public MainWindowView()
        {
            InitializeComponent();
                                 
        }

        private bool CheckActivate(Type type)
        {
            foreach ( BaseDocument item in documentManager.View.Documents)
            {
                if (item.Form.GetType() == type)
                {
                    documentManager.View.ActivateDocument(item.Form);
                    return true;
                }
            }
            return false;
        }

        private void btFilms_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            if (!CheckActivate(typeof(FilmsView)))
            {
                FilmsView form = new FilmsView();
                form.MdiParent = this;
                form.Show();
            }
            
        }

        private void btHalls_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckActivate(typeof(HallsView)))
            {
                HallsView form = new HallsView();
                form.MdiParent = this;                
                form.Show();
            }
            
        }
    }
}
