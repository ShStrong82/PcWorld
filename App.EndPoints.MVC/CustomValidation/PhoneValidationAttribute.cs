using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.MVC.CustomValidation;

public class PhoneValidationAttribute : ValidationAttribute
{
    public string DefaultMessage { get; set; } = "شماره ی وارد شده حتما باید بصورت 09*** باشد";
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        string phone = (string)value;
        if (phone is not null)
        {
            if (phone.Substring(0, 2) is not "09")
                return new ValidationResult(string.Format(ErrorMessage ?? DefaultMessage, validationContext.DisplayName));
            return ValidationResult.Success;
        }

        return null;
    }
}
