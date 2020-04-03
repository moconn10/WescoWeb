using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WescoWeb.Models
{
    public class wesco
    {
        [Key]
        public int wescoID { get; set; }
        public string password { get; set; }
        public string managerfname { get; set; }
        public string managerlname { get; set; }
    }
}