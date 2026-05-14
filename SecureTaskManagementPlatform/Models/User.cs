using System.ComponentModel.DataAnnotations;

namespace SecureTaskManagementPlatform.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$")]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = "User";
    }
}