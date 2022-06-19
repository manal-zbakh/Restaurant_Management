using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class Serveur
    {
        [Key]
        public int num_srv { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        //public Affecter Affecter { get; set; }

        public ICollection<Affecter> affecters { get; set; }
    }
}
