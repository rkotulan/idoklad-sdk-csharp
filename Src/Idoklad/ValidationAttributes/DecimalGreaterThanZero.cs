using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace IdokladSdk.ValidationAttributes
{
    internal class DecimalGreaterThanZero : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if ((decimal)value <= 0)
                {
                    return new ValidationResult(string.Format(this.ErrorMessageString, validationContext.DisplayName));
                }
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception.Message);
            }

            return ValidationResult.Success;
        }
    }
}