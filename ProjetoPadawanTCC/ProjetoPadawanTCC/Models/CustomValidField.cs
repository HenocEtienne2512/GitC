using ProjetoPadawanTCC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjetoPadawanTCC.Models {
    public class CustomValidField: ValidationAttribute {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidField(ValidFields type) {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value,
             ValidationContext validationContext) {
            if (value != null) {
                switch (typeField) {
                    case ValidFields.ValidaEmail: {
                            return ValidaEmail(value, validationContext.DisplayName);
                        }
                    case ValidFields.ValidaPlaca: {
                            return ValidaPlaca(value, validationContext.DisplayName);
                        }
                    default: { } break;
                }
            }
            return new ValidationResult($"O campo {validationContext.DisplayName} é obligatório.");
        }

        private ValidationResult ValidaEmail(object value, string displayField) {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é inválido.");
        }

        private ValidationResult ValidaPlaca(object value, string displayField) {
            if (EPlacaValida(value.ToString()))
                return ValidationResult.Success;

            return new ValidationResult($"A Placa {displayField} é inválido.");
        }
        bool EPlacaValida(string value) {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");

            if (regex.IsMatch(value)) {
                return true;
            }

            return false;
        }
    }
}