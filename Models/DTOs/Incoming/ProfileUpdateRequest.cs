using System.ComponentModel.DataAnnotations;

namespace CarPartStore.Models.DTOs.Incoming
{
    public class ProfileUpdateRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string LasttName { get; set; } = string.Empty;
        public string PatroName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
