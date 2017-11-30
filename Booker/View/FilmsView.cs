using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booker.Model;
using Booker.Helper;

namespace Booker.View
{
    public partial class FilmsView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BindingList<Film> filmList;

        public FilmsView()
        {
            InitializeComponent();
            filmList = new BindingList<Film>(DataHelper.LoadFilms());            
            gridControl.DataSource = filmList;
        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataHelper.SaveFilms(new List<Film>(filmList));
        }
        
    }
}
