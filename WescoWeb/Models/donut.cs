using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WescoWeb.Models
{
    public class donut
    {
        public int donutID { get; set; }
        public DateTime date { get; set; }
        public int ordered { get; set; }
        public int sold { get; set; }
        public int wasted { get; set; }
        public string name { get; set; }
        public int production { get; set; }
        public float price { get; set; }
    }
}