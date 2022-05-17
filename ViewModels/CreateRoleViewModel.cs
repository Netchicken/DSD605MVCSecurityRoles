using System.ComponentModel.DataAnnotations;

namespace DSD605MVCSecurityRoles.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; } = string.Empty;
    }
}
