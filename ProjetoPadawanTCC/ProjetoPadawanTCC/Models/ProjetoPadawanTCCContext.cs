using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models
{
    public class ProjetoPadawanTCCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjetoPadawanTCCContext() : base("name=ProjetoPadawanTCCContext")
        {
        }

        public System.Data.Entity.DbSet<ProjetoPadawanTCC.Models.TipoVeiculos> TipoVeiculos { get; set; }

        public System.Data.Entity.DbSet<ProjetoPadawanTCC.Models.Marcas> Marcas { get; set; }

        public System.Data.Entity.DbSet<ProjetoPadawanTCC.Models.Modelos> Modelos { get; set; }

        public System.Data.Entity.DbSet<ProjetoPadawanTCC.Models.Cores> Cores { get; set; }

        public System.Data.Entity.DbSet<ProjetoPadawanTCC.Models.Veiculos> Veiculos { get; set; }
    }
}
