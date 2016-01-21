using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace IdokladSdk
{
    public static class ApiValidator
    {
        /// <summary>
        /// Validates object based on object's data annotations
        /// </summary>
        public static bool ValidateObject(object obj, out List<ValidationMessage> errors)
        {
            var innerResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, new ValidationContext(obj), innerResults);

            errors = innerResults.Select(x => new ValidationMessage{Message = x.ErrorMessage, MemberNames = x.MemberNames}).ToList();
            return isValid;
        }
    }
}
