using WhereIsMyMoney.BLL.Abstraction.Services;
using WhereIsMyMoney.DomainModels.Auth.Requests;
using WhereIsMyMoney.DomainModels.DTO.User;

namespace WhereIsMyMoney.BLL.Services;

public class AuthService : IAuthService
{
    public Task<UserDto> SignIn(SignInRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> SignUp(SignUpRequest request)
    {
        throw new NotImplementedException();
    }
}