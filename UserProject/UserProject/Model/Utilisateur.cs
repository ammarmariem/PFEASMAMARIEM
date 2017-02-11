using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProject.Model
{
   public class Utilisateur
    {
        public String nom { get; set; }
        public String prenom { get; set; }
        public int telephone { get; set; }
        public int cin { get; set; }
        public DateTime dateNaissance { get; set; }
        public String email { get; set; }
        public String motDePasse { get; set; }
        public  String confirmerMotPasse { get; set; }
    }

}
