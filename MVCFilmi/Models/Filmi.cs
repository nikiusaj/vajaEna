using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilmi.Models
{
    public class Filmi
    {
        public int Id{ get; set; }
        public int Naslov { get; set; }
        public int Izdanm { get; set; }
        public int Tip { get; set; }
        public int Cena { get; set; }
    }
}