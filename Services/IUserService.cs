using CarPartStore.Models.DTOs.Outgoing;
using CarPartStore.Models.DTOs.Incomig;

namespace CarPartStore.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<AuthenticateResponse> Register(AuthenticateRequest model);
    }
}
