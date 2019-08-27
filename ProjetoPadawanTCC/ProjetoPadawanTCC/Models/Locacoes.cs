using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Locacoes: UserControls {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Veiculo")]
        public TipoVeiculos veiculo { get; set; }
        public int Veiculo { get; set; }

        [ForeignKey("Marca")]
        public Marcas marcas { get; set; }
        public int Marca { get; set; }

        [ForeignKey("Modelo")]
        public Modelos modelos { get; set; }
        public int Modelo { get; set; }

        [ForeignKey("Cor")]
        public Cores cores { get; set; }
        public int Cor { get; set; }

        [ForeignKey("Placa")]
        public Veiculos veiculos { get; set; }
        public int Placa { get; set; }

        [ForeignKey("CodPeriodo")]
        public Periodos periodos { get; set; }
        public int CodPeriodo { get; set; }

        [ForeignKey("UsuarioLoc")]
        public UsuariosLocador usuario { get; set; }
        public int UsuarioLoc { get; set; }
    }
}