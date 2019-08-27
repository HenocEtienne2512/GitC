using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class TermoUso  {
        [Required]
        [MinLength(25)]
        [MaxLength(2500)]
        public int CodidoTermoo { get; set; }
        public string Descricao { get; set; }
        public bool Vigente { get; set; }
    }
}