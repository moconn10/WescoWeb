using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WescoWeb.Models
{
    public class employee
    {
        public int employeeID { get; set; }
        public float hours { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public Boolean deliver { get; set; }
    }
}
