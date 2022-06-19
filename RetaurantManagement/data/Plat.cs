using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class Plat
    {
        [Key]
        public int code_plat { get; set; }
        public string libelle { get; set; }
        public float prix { get; set; }
        public Type Type { get; set; }

       //public Contient Contient { get; set; }
       public ICollection<Contient> contients { get; set; }
    }
}
