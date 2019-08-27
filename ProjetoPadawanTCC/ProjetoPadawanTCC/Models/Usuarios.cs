using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Usuarios {
        [Key]
        public int CodUsu { get; set; }
        public string Tipo { get; set; }
        

    }
}