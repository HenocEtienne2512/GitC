using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Colaborador: Usuarios {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public bool IsPcd { get; set; }
        public bool IsMinicipio { get; set; }
        public bool OferCarona { get; set; }
    }
}