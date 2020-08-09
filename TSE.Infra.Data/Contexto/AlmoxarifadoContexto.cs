using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSE.Infra.Data.Migrations;

namespace TSE.Infra.Data.Contexto
{
     public class AlmoxarifadoContexto : DbContext
    {
       public AlmoxarifadoContexto() : base("Server = localhost; Database=master;Trusted_Connection=True;")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AlmoxarifadoContexto, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


        }
    }
}

