using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class Table
    {
        [Key]
        public int num_tab { get; set; }
        public int nb_place { get; set; }


         public Affecter Affecter { get; set; }
        //public ICollection<Affecter> affecters { get; set; }

        public Commande Commande { get; set; }

    }
}
