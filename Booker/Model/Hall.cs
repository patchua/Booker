
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Model
{
    public class Hall
    {
        public Hall() {}
        public Hall(string name, int cap, bool s2d, bool s3d, bool s4d)
        {
            Name = name;
            Capacity = cap;
            Support2D = s2d;
            Support3D = s3d;
            Support4D = s4d;
        }
        //public string CinemaName { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool Support2D { get; set; }
        public bool Support3D { get; set; }
        public bool Support4D { get; set; }

    }
}
