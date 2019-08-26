using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models {
    public class CustomNameValidator: ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value != null) {
                if (value.ToString().Contains("HENOC")){
                    return ValidationResult.Success;
                } else {
                    return new ValidationResult("Tentar novamente");
                }
            }
            return new ValidationResult("O campo: " + validationContext.DisplayName + "é um ampo obligatório");
        }
    }
}