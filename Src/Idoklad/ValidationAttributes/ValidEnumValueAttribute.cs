using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ValidationAttributes
{
    internal class ValidEnumValueAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var enumType = value.GetType();
                var valid = Enum.IsDefined(enumType, value);
                if (!valid)
                {
                    return
                        new ValidationResult(
                            string.Format("{0} is not a valid value for type {1}", value, enumType.Name));
                }
            }

            return ValidationResult.Success;
        }
    }
}