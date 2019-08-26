using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiExoFinal.Models {
    public class Usuario: UserControls {
        [Key]
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string EstadoCivil { get; set; }

        public string Rg { get; set; }
        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string NomeFantasia { get; set; }

        public string Cep { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Fone { get; set; }

        public string Celular { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

    }
}