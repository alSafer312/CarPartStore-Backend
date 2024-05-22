using CarPartStore.Enums;
using System.Text.Json.Serialization;

namespace CarPartStore.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LasttName { get; set; } = string.Empty;
        public string PatroName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public UserRoleEnum Role { get; set; }
        public DateTime CreatedOn { get; set; }
        public string VeryficationToken { get; set; } = string.Empty;

        /*
        [JsonIgnore]
        public virtual Cart cart { get; set; }
        [JsonIgnore]
        public virtual Order order { get; set; }
        */
    }
}
