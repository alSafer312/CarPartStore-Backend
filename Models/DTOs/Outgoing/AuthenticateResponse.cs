namespace CarPartStore.Models.DTOs.Outgoing
{
    public class AuthenticateResponse
    {
        public string AccesToken { get; set; }
        public string Email { get; set; }
        public AuthenticateResponse(User user, string token)
        {
            Email = user.Email;
            AccesToken = token;
        }
    }
}
