using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WebApiExoFinal.Enums;

namespace WebApiExoFinal.Models {
    public class CustomValidFields : ValidationAttribute {

        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type) {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value != null) {
                switch (typeField) {

                    case ValidFields.ValidaRg: { }break;
                    case ValidFields.ValidaCpf: { }break;
                    case ValidFields.ValidaCnpj: { }break;
                    case ValidFields.ValidaCep: { }break;
                    case ValidFields.ValidaTel: { }break;
                    case ValidFields.ValidaCelular: { }break;
                    case ValidFields.ValidaEmail: { }break;
                    default: { }break;
                }

            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obligatório.");
        }

        private ValidationResult ValidarEmail(object value, string displayField) {

            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result) {
                return ValidationResult.Success;

            }
            return new ValidationResult($"O campo {displayField} é inválido.");
        }

        private ValidationResult ValidarTelefone(object value, string displayField) {

            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result) {
                return ValidationResult.Success;

            }
            return new ValidationResult($"O campo {displayField} é inválido.");
        }
        private ValidationResult ValidarCpf(object value, string displayField) {

            bool result = Regex.IsMatch(value.ToString(), @"^\d{3}\x2E\d{3}\x2E\d{3}\x2D\d{2}$");

            if (result) {
                return ValidationResult.Success;

            }
            return new ValidationResult($"O campo {displayField} é inválido.");
        }
    }
}