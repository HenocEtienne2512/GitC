using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Cores: UserControls {
        [Key]
        public int CodigoCor { get; set; }
        public string Descricao { get; set; }
    }
}