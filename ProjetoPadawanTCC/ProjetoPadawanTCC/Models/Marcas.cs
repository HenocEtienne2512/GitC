using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Marcas: UserControls {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }

        [ForeignKey("Veiculo")]
        public TipoVeiculos veiculos { get; set; }
        public int Veiculo { get; set; }
    }
}