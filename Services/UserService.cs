using CarPartStore.Data;
using CarPartStore.Extensions;
using CarPartStore.Helpers;
using CarPartStore.Models;
using CarPartStore.Models.DTOs.Incomig;
using CarPartStore.Models.DTOs.Outgoing;

namespace CarPartStore.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        private readonly IConfiguration _configuration;

        public UserService(DataContext dataContext, IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest request)
        {
            var user = _dataContext.Users.FirstOrDefault(u => u.Email == request.Email);
            if (user == null)
            {
                // todo: need to add logger
                return null;
            }
            if (!request.Password.TrustTo(user.PasswordHash))
            {
                // todo: need to add logger
                return null;
            }

            var token = _configuration.GenerateJwt(user);
            return new AuthenticateResponse(user, token);
        }

        public async Task<AuthenticateResponse> Register(AuthenticateRequest request)
        {
            var user = new User();
            if (_dataContext.Users.Any(u => u.Email == request.Email))
            {
                // todo: need to add logger
                return null;
            }

            user.Email = request.Email;
            user.PasswordHash = request.Password.ConvertToHash();
            //user.PasswordSalt = passwordSalt;
            user.Role = Enums.UserRoleEnum.Customer;
            user.CreatedOn = DateTime.Now;

            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            var response = Authenticate(new AuthenticateRequest
            {
                Email = request.Email,
                Password = request.Password
            });

            return response;
        }

        public async Task<>
    }
}
