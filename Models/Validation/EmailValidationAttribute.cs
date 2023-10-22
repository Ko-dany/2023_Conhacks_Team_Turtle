using System.ComponentModel.DataAnnotations;

namespace Team_Turtle.Models.Validation
{
    public class EmailValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string email = value.ToString();
            if (email != null && email.EndsWith("@conestogac.on.ca"))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Email must end with @conestogac.on.ca");
            }
        }
    }
}
