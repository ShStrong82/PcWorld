using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.MVC.Models;

public class LoginViewModel
{
    [Required]
    [Display(Name = "ایمیل")]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [Display(Name = "رمز ورود")]
    public string Password { get; set; }
    public string? ReturnUrl { get; set; }
}
