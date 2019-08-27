using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Modelos: UserControls {
        [Key]
        public int CodigoModelo { get; set; }
        public string Descricao { get; set; }
        public virtual Marcas CodigoMarca { get; set; }

        public virtual TipoVeiculos CodigoTipo { get; set; }
    }
}