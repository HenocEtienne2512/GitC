using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class Periodos {
        [Key]
        public int CodigoPeriodo { get; set; }

        [JsonIgnore]
        public virtual TipoVeiculos CodigoTipo{get;set;}

        //[Required]
        //[DataType(DataType.Date)]
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }

       // [Required]
        //[DataType(DataType.Date)]
      //  [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFim { get; set; } 

        //[Required]
        public bool Vigente { get; set; }

        public Periodos(){

            if (DateTime.Today <= DataFim) {
                Vigente = true;
            } else {
                Vigente = true;
            }

        }
        
    }
}