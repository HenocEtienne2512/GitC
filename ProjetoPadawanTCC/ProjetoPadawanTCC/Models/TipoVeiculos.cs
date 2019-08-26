using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class TipoVeiculos: UserControls {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
    }
}