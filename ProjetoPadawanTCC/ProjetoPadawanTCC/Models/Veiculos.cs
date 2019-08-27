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
     
        public virtual Usuarios CodUsu { get; set; }

        public virtual TipoVeiculos codigoTipo { get; set; }     

        public virtual Marcas CodigoMarca { get; set; }

        public virtual Modelos CodigoModelo { get; set; }

        public virtual Cores CodigoCor { get; set; }

        public string Placa { get; set; }
    }
}