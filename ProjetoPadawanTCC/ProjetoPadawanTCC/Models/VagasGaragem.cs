using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class VagasGaragem {
        public int CodigoVaga { get; set; }
        public virtual TipoVeiculos CodigoTipo { get; set; }
        public int QtdVagas { get; set; }
    }
}