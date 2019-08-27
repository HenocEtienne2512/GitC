using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Locacoes: UserControls {
        [Key]
        public int CodigoLocacao { get; set; }

        public virtual TipoVeiculos CodigoTipo { get; set; }

        public virtual Marcas CodigoMarca { get; set; }

        public virtual Modelos CodigoModelo { get; set; }

        public virtual Cores CodigoCor { get; set; }

        public virtual Veiculos veiculos { get; set; }

        public virtual Periodos CodigoPeriodo { get; set; }

        public virtual Usuarios CodUsu { get; set; }
    }
}