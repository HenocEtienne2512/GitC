using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Locacoes: UserControls {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Veiculo")]
        public TipoVeiculos veiculo { get; set; }
        public int Veiculo { get; set; }
        public int MarcaFK { get; set; }
        public int ModeloFK { get; set; }
        public int CorFK { get; set; }
        public int PlacaFK { get; set; }
        public int CodPeriodo { get; set; }
        public int UsuarioLocFK { get; set; }      
    }
}