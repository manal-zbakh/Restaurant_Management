using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class Affecter
    {
        [Key]
        public int id_affect { get; set; }
        public DateTime date { get; set; }

        /* [Required]
         [ForeignKey("Serveur")]
         [Column("serveurid")]
         public int serveurId { get; set; } 
         public Serveur Serveur { get; set; }


         [Required]
         [ForeignKey("Table")]
         [Column("tableid")]
         public int tableId { get; set; }

         public Table Table { get; set; }*/
       // [Required]
       // [ForeignKey("Serveur")]
       // [Column("serveurid")]
       // public int ServeurId { get; set; }
        public Serveur Serveur { get; set; }

      //  [Required]
       // [ForeignKey("Table")]
      //  [Column("tableid")]
       // public int TableId { get; set; }

       public Table Table { get; set; }
        //public ICollection<Table> tables { get; set; }
    }
}
