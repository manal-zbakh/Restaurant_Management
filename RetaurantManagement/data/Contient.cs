using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class Contient
    { 
        [Key]
        public int id_contient { get; set; }

        public int quantite { get; set; }

        public Plat Plat { get; set; }
        public Commande Commande { get; set; }

    }
}
