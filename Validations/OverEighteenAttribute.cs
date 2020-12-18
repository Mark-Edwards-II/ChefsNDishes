using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Validations
{
    public class OverEighteenAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime compare = (DateTime)value;
            if( DateTime.Now.AddYears(-18) >= (DateTime)value )
            {
                return new ValidationResult("You must be 18 years old to sugn up.");
            }
            return ValidationResult.Success;
        }
    }
}