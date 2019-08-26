using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Veiculos {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UsuarioLoc")]
        public UsuariosLocador usuario { get; set; }
        public int UsuarioLoc { get; set; }

        [ForeignKey("Tipo")]
        public TipoVeiculos tipoVeiculos { get; set; }
        public int Tipo { get; set; }

        [ForeignKey("Marca")]
        public Marcas marcas { get; set; }
        public int Marca { get; set; }

        [ForeignKey("Modelo")]
        public Modelos modelos { get; set; }
        public int Modelo { get; set; }

        [ForeignKey("Cor")]
        public Cores cores { get; set; }
        public int Cor { get; set; }

        public string Placa { get; set; }
    }
}