using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminProject.Model
{
    class Admin
    {
        public int id {get; set;}
        public String nom {get; set;}
        public String prenom {get; set;}
        public String email {get; set;}
        public String motdepasse {get; set;}
        public String image { get; set; }
        public String facebook {get; set;}
        public String twitter {get; set;}
    }
}
