using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Marcas: UserControls {
        [Key]
        public int CodigoMarca { get; set; }
        public string Descricao { get; set; }

        public virtual TipoVeiculos CodigoTipo { get; set; }
    }
}