using Microsoft.AspNetCore.Mvc;
using WhereIsMyMoney.BLL.Abstraction.Services;
using WhereIsMyMoney.DomainModels.Auth.Requests;

namespace WhereIsMyMoney.API.Controllers.Auth;

[ApiController]
[Route("api/auth/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    
    public AuthController(IAuthService authService)
    {
        this._authService = authService;
    }
    
    [HttpPost("sign-in")]
    public async Task<IActionResult> SignIn([FromBody] SignInRequest request)
    {
        return Ok(await _authService.SignIn(request));
    }
    
    [HttpPost("sign-up")]
    public async Task<IActionResult> SignUp([FromBody] SignUpRequest request)
    {
        return Ok(await _authService.SignUp(request));
    }

}