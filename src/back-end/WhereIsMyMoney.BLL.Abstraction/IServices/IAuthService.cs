using WhereIsMyMoney.DomainModels.Auth.Requests;
using WhereIsMyMoney.DomainModels.DTO.User;

namespace WhereIsMyMoney.BLL.Abstraction.Services;

public interface IAuthService
{
    public Task<UserDto>SignIn(SignInRequest request);
    public Task<UserDto> SignUp(SignUpRequest request);
}