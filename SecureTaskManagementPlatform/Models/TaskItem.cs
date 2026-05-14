using System.ComponentModel.DataAnnotations;

namespace SecureTaskManagementPlatform.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}