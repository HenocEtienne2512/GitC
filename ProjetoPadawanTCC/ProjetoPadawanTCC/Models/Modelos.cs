using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Modelos: UserControls {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }

        [ForeignKey("Marca")]
        public Marcas marcas { get; set; }
        public int Marca { get; set; }

        [ForeignKey("Veiculo")]
        public TipoVeiculos veiculos { get; set; }
        public int Veiculo { get; set; }
    }
}