using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaurantManagement.data
{
    public class MyDB:DbContext
    {
        public MyDB() : base("name=cnx") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Table>().ToTable("tables");
            modelBuilder.Entity<Serveur>().ToTable("serveurs");
            modelBuilder.Entity<Affecter>().ToTable("affecter");
            modelBuilder.Entity<Plat>().ToTable("plats");
            modelBuilder.Entity<Type>().ToTable("types");
            modelBuilder.Entity<Commande>().ToTable("commandes");
            modelBuilder.Entity<Contient>().ToTable("contient");

            modelBuilder.Entity<Affecter>().HasRequired(x => x.Serveur)
              .WithMany(x => x.affecters)
              .Map(x => x.MapKey("ServeurId"));

            modelBuilder.Entity<Affecter>().HasRequired(x => x.Table)
               .WithOptional(x => x.Affecter)
               .Map(x => x.MapKey("TableId"));


            modelBuilder.Entity<Plat>().HasRequired(x => x.Type)
              .WithMany(x => x.Plat)
              .Map(x => x.MapKey("id_type"));


            modelBuilder.Entity<Commande>().HasRequired(x => x.Table)
              .WithOptional(x => x.Commande)
              .Map(x => x.MapKey("num_tab"));


            modelBuilder.Entity<Contient>().HasRequired(x => x.Commande)
              .WithMany(x => x.contients)
              .Map(x => x.MapKey("num_cmd"));

           /* modelBuilder.Entity<Contient>().HasRequired(x => x.Plat)
               .WithOptional(x => x.Contient)
               .Map(x => x.MapKey("code_plat"));*/

            modelBuilder.Entity<Contient>().HasRequired(x => x.Plat)
               .WithMany(x => x.contients)
               .Map(x => x.MapKey("code_plat"));


        }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Affecter> Affecters { get; set; }
        public virtual DbSet<Serveur> Serveurs { get; set; }
        public virtual DbSet<Plat> Plats { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Contient> Contients { get; set; }
    }
}
