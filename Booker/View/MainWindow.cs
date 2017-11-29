using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booker.View
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int film_index = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btFilms_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Films form = new Films();
            form.MdiParent = this;
            form.Name = "Film" + film_index.ToString();
            film_index++;
            form.Show();
        }
    }
}
