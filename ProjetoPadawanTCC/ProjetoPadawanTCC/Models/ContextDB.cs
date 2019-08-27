using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class ContextDB: DbContext {
        public DbSet<TipoVeiculos> tipoVeiculos { get; set; }
        public DbSet<Veiculos> veiculos { get; set; }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Modelos> modelos{ get; set; }
        public DbSet<Cores> cores { get; set; }
        public DbSet<TermoUso> termoUsos { get; set; }
        public DbSet<Periodos> periodos { get; set; }
        public DbSet<VagasGaragem> vagasGaragem { get; set; }
        public DbSet<Locacoes> locacoes { get; set; }
    }
}