using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Input;

namespace ProjetoPadawanTCC.Models {
    public class TermoUso  {
        [Key]       
        public int CodigoTermo { get; set; }
        [Required]
        [MinLength(25)]
        [MaxLength(2500)]
        public string Descricao { get; set; }
        public bool Vigente { get; set; }
    }
}