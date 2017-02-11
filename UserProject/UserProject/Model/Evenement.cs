using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Model
{
    public class Evenement

    {
        public String nom {get;set;}
        public String description { get; set; }
        public DateTime datetemp { get; set; }
        public String duree { get; set; }
        public String lieu { get; set; }
        public String type { get; set; }
        public int budget { get; set; }
    }
}
