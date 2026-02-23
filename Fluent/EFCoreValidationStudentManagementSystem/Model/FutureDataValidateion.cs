using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreValidationStudentManagementSystem.Model
{
    public class FutureDataValidateion : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime date && date > DateTime.Now)
            {
                return new ValidationResult("Enrollment date cant be in future date.");
            }
            return ValidationResult.Success;

        }
    }
}
