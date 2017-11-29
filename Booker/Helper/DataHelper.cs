using BookingHelper.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookingHelper.Helper
{
    public class DataHelper
    {
        public string DataPath = System.IO.Directory.GetCurrentDirectory();
        string filmFile = "film.bh";
        string cinemaFile = "cinema.bh";
        
        //Create type-not-specific Loader and Saver and utilize them
        public List<Film> LoadFilms()
        {
            List<Film> list = new List<Film>();
            string file = DataPath + filmFile;
            if (File.Exists(file))
              list=JsonConvert.DeserializeObject<List<Film>>(DataPath + filmFile);
            return list;
        }

        public bool SaveFilms(List<Film> films)
        {
           
            string output=JsonConvert.SerializeObject(films);
            string file = DataPath + "\\"+filmFile;
            if (File.Exists(file))
            {
                string move_to = DataPath + "\\" +  DateTime.Now.ToString("yyyyMMddHHmmss") + filmFile;
                File.Move(file, move_to);
            }
            File.WriteAllText(file, output);

            return true;
        }

        
    }
}
