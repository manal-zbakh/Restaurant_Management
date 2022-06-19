using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class Commande
    {
        [Key]
        public int num_cmd { get; set; }
        public DateTime date_com { get; set; }
        public int nb_personnes { get; set; }
        public TimeSpan heure_paiment { get; set; }
        public string mode_paiment { get; set; }
        public Table Table { get; set; }
        public ICollection<Contient> contients { get; set; }


    }
}
