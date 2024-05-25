using App.EndPoints.MVC.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.MVC.Models;

public class RegisterViewModel
{
    [Required]
    [Display(Name = "نام")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "نام خانوادگی")]
    public string LastName { get; set; }
    [Required]
    [Display(Name = "ایمیل")]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [Display(Name = "رمز ورود")]
    public string Password { get; set; }
    [Required]
    [Display(Name = "تکرار رمز ورود")]
    [Compare(nameof(Password), ErrorMessage = "با پسورد وارد شده مطابقت ندارد!")]
    public string ConfirmPassword { get; set; }
    [Required]
    [Display(Name = "شماره موبایل")]
    [PhoneValidation]
    public string mobile { get; set; }
    public string? ReturnUrl { get; set; }
}
