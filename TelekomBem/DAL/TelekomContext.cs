using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TelekomBem.Model;


namespace TelekomBem.DAL
{
    class TelekomContext:DbContext
    {
        public TelekomContext() : base("TelekomBem")
        {

        }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Mdl> Modeller { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
