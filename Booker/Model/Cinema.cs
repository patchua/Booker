﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Booker.Model
{
    public class Cinema
    {
        public Cinema()
        {
            Halls = new List<Hall>();
        }
        public Cinema(string name, DateTime open, DateTime close):this()
        {
            Name = name;
            Open = open;
            Close = close;
        }
        public string Name { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public List<Hall> Halls { get; set; }
        public int Capacity
        {
            // per day in minutes
            get
            {
                TimeSpan span = Close.Subtract(Open);
                return (int)span.TotalMinutes;
            }
        }

    }
}
