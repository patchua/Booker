using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Booker.Model;

namespace Booker.View
{
    public partial class PlanView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private class WeekPlanView
        {
            string Week1 { get; set; }
            string Week2 { get; set; }
            string Week3 { get; set; }
            string Week4 { get; set; }
            string Week5 { get; set; }
            string FilmName { get; set; }            

        }
        private Plan plan;

        public PlanView()
        {
            InitializeComponent();
            plan = new Plan();
            
        }

        private void btOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraEditors.XtraFolderBrowserDialog dlg = new DevExpress.XtraEditors.XtraFolderBrowserDialog();
            dlg.ShowDialog();


        }

        private void btSave_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btNew_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}