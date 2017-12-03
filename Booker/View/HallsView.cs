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

        public class CinemaHall : Hall
        {
            public string CinemaName { get; set; }
            public CinemaHall(string cname, Hall h)
            {
                CinemaName = cname;
                this.Name = h.Name;
                this.Capacity = h.Capacity;
                this.Support2D = h.Support2D;
                this.Support3D = h.Support3D;
                this.Support4D = h.Support4D;
            }
            public CinemaHall()
            {

            }
        }

        private BindingList<CinemaHall> cinemaHallsList= new BindingList<CinemaHall>();
        private List<Cinema> cinemaList =  new List<Cinema>();
        private List<string> cinemaNames= new List<string>();
        private int index = 0;
        public HallsView()
        {
            InitializeComponent();            
        }

        private void HallsView_Load(object sender, EventArgs e)
        {
            cinemaList = DataHelper.LoadCinemas();
            //cinemaHallsList = new BindingList<CinemaHall>();
            try
            {
                foreach (Cinema cin in cinemaList)
                {
                    cinemaNames.Add(cin.Name);
                    if (cin.Halls != null)
                    {
                        foreach (Hall h in cin.Halls)
                            cinemaHallsList.Add(new CinemaHall(cin.Name, h));
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
            }            
            gridControl.DataSource = cinemaHallsList;            
            repositoryItemComboBoxCinema.Items.AddRange(cinemaNames);
            gridView.Columns["CinemaName"].ColumnEdit = repositoryItemComboBoxCinema;
        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<Cinema> toSaveList = new List<Cinema>();
            foreach (CinemaHall chall in cinemaHallsList)
            {
                Cinema cinema = cinemaList.Find(x => x.Name == chall.CinemaName);
                toSaveList.Add(new Cinema(cinema.Name, cinema.Open, cinema.Close));
            }
            foreach (CinemaHall chall in cinemaHallsList)
            {
                Hall h = new Hall(chall.Name, chall.Capacity, chall.Support2D, chall.Support3D, chall.Support4D);
                toSaveList.Find(x => x.Name == chall.CinemaName).Halls.Add(h);
            }
            cinemaList = toSaveList;
            DataHelper.SaveCinemas(cinemaList);
        }

        private void btAddCinema_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Add a form to set all proper values
            Cinema cinema = new Cinema();
            cinema.Name = "new" + index.ToString();
            index++;
            cinemaNames.Add(cinema.Name);
            repositoryItemComboBoxCinema.Items.Add(cinema.Name);
            cinemaList.Add(cinema);
        }
    }
}
