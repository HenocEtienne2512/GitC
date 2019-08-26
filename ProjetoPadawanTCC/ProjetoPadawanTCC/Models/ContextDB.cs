using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class ContextDB: DbContext {
        public DbSet<TipoVeiculos> veiculos { get; set; }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Cores> cores { get; set; }
        public DbSet<Locacoes> locacoes { get; set; }
    }
}