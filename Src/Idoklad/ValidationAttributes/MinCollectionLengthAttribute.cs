using System;
using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ValidationAttributes
{
    internal class MinCollectionLengthAttribute : CollectionRangeAttribute
    {
        public MinCollectionLengthAttribute(int minLength) : base(minLength, int.MaxValue)
        {
        }

        protected override string InvalidCollectionLengthValidationMessage(ValidationContext validationContext, int length)
        {
            return $"{validationContext.DisplayName} must have at least {this.MinLength} elements. Actual number of elements is {length}";
        }

        protected override bool IsCollectionLengthValid(int length)
        {
            return length >= this.MinLength;
        }

        protected override string NullCollectionValidationMessage(ValidationContext validationContext)
        {
            return $"{validationContext.DisplayName} can not be null. Must have at least {this.MinLength} elements.";
        }

        protected override void EnsureLegalLengths()
        {
            if (this.MinLength < 0)
            {
                throw new InvalidOperationException($"{nameof(CollectionRangeAttribute)} invalid MinimumLength value. Must be greater than 0.");
            }
        }
    }
}