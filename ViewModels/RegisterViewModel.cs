using System.ComponentModel.DataAnnotations;
namespace authProject.ViewModels
{    
public class RegisterViewModel
{
    [Required] public string Email { get; set; }
    [Required] [DataType(DataType.Password)] public string Password { get; set; }
    [DataType(DataType.Password)] [Compare("Password")] public string ConfirmPassword { get; set; }
}

}
