using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ValidationAttributes
{
    internal class CollectionRangeAttribute : ValidationAttribute
    {
        public CollectionRangeAttribute()
        {
            this.MinLength = 0;
            this.MaxLength = int.MaxValue;
        }

        public CollectionRangeAttribute(int minLength, int maxLength)
        {
            this.MinLength = minLength;
            this.MaxLength = maxLength;
        }


        protected int MaxLength { get; set; }
        protected int MinLength { get; set; }

        protected virtual void EnsureLegalLengths()
        {
            if (this.MinLength < 0)
            {
                throw new InvalidOperationException($"{nameof(CollectionRangeAttribute)} invalid MinimumLength value. Must be greater than 0.");
            }

            if (this.MinLength > this.MaxLength)
            {
                throw new InvalidOperationException($"{nameof(CollectionRangeAttribute)} invalid range values. MaximumLength must be greater or equal MinimumLength. MaximumLength: {this.MaxLength} MinimumLength:{this.MinLength}");
            }
        }

        protected virtual string InvalidCollectionLengthValidationMessage(ValidationContext validationContext, int length)
        {
            return $"{validationContext.DisplayName} count is not within required range <{this.MinLength}, {this.MaxLength}>. Actual length is {length}";
        }

        protected virtual bool IsCollectionLengthValid(int length)
        {
            return (length >= this.MinLength) && (length <= this.MaxLength);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            this.EnsureLegalLengths();

            var collection = value as ICollection;
            if (collection == null)
            {
                return new ValidationResult(this.NullCollectionValidationMessage(validationContext));
            }

            var length = collection.Count;
            var isValid = this.IsCollectionLengthValid(length);
            return isValid ?
                ValidationResult.Success :
                new ValidationResult(this.InvalidCollectionLengthValidationMessage(validationContext, length));
        }

        protected virtual string NullCollectionValidationMessage(ValidationContext validationContext)
        {
            return $"{validationContext.DisplayName} must be a collection with length within required range <{this.MinLength}, {this.MaxLength}>.";
        }
    }
}