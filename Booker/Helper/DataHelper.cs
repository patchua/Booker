﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Booker.Model;

namespace Booker.Helper
{
    public static class DataHelper
    {
        private static string DataPath = System.IO.Directory.GetCurrentDirectory();
        const string  filmFile = "film.bh";
        const string hallFile = "hall.bh";
        const string cinemaFile = "cinema.bh";
        public const string planFileFilter = "Plan file|*.plan";

        public static List<Film> LoadFilms()
        {
            return Load<Film>(filmFile);
        }
        public static List<Cinema> LoadCinemas()
        {
            return Load<Cinema>(cinemaFile);
        }
        public static List<Hall> LoadHalls()
        {
            return Load<Hall>(hallFile);
        }
        public static Plan LoadPlan(string fileName)
        {
            List<Plan> r= Load<Plan>(fileName);
            return r.ElementAt(0);
        }
        public static void SaveFilms(List<Film> list)
        {
            Save<Film>(list, filmFile);
        }
        public static void SaveHalls(List<Hall> list)
        {
            Save<Hall>(list, hallFile);
        }
        public static void SaveCinemas(List<Cinema> list)
        {
            Save<Cinema>(list, cinemaFile);
        }
        public static void SavePlan(Plan plan,string fileName)
        {
            List<Plan> list = new List<Plan>();
            list.Add(plan);
            Save<Plan>(list, fileName);
        }
        

        private static List<T> Load<T>(string file)
        {
            List<T> list = new List<T>();
            string filepath = DataPath + "\\"+file;
            if (File.Exists(filepath))            
                list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filepath));            
            return list;
        }
        private static void Save<T>(List<T> list, string file)
        {
           
            string output=JsonConvert.SerializeObject(list);
            string filepath = DataPath + "\\"+file;
            // create backup on eachj save
            /*if (File.Exists(filepath))
            {
                string move_to = DataPath + "\\" +  DateTime.Now.ToString("yyyyMMddHHmmss") + file;
                File.Move(file, move_to);
            }
            */
            File.WriteAllText(filepath, output);
          
        }        
    }
}
