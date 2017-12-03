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
using DevExpress.XtraEditors;
using Booker.Model;
using Booker.Helper;

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
        private Plan plan= new Plan();
        private string filePath="";
        private List<Cinema> cinemaList= new List<Cinema>();
        private List<Film> filmList= new List<Film>();
        


        public PlanView()
        {
            InitializeComponent();                                    
        }

        private void btOpen_ItemClick(object sender, ItemClickEventArgs e)
        {

            XtraOpenFileDialog dlg = new XtraOpenFileDialog();
            dlg.Filter = DataHelper.planFileFilter;
            dlg.Multiselect = false;             
            dlg.ShowDialog();
            if (dlg.FileName != null)                
            {
                filePath = dlg.FileName;
                btSave.Enabled = true;
                plan = DataHelper.LoadPlan(filePath);
            }
        }

        private void btSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataHelper.SavePlan(plan, filePath);
        }     

        private void btSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraSaveFileDialog dlg = new XtraSaveFileDialog();
            dlg.Filter = DataHelper.planFileFilter;
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                filePath = dlg.FileName;
                btSave.Enabled = true;
                DataHelper.SavePlan(plan, filePath);
            }
        }

        private void PlanView_Load(object sender, EventArgs e)
        {
            cinemaList = DataHelper.LoadCinemas();
            filmList = DataHelper.LoadFilms();
        }

        private void btRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            cinemaList = DataHelper.LoadCinemas();
            filmList = DataHelper.LoadFilms();
        }
    }
}