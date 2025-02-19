using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using WhereIsMyMoney.BLL.Abstraction.Services;
using WhereIsMyMoney.BLL.Services;
using WhereIsMyMoney.DomainModels.Auth.Requests;
using WhereIsMyMoney.DomainModels.DTO.User;

namespace WhereIsMyMoney.BLL.UnitTests.Services;

[TestFixture]
public class AuthServiceTests
{
    private Mock<IAuthService> _authServiceMock;
    private AuthService _authService;

    [SetUp]
    public void SetUp()
    {
        _authServiceMock = new Mock<IAuthService>();
        _authService = new AuthService();
    }

    [Test]
    public async Task SignIn_ValidRequest_ReturnsUserDto()
    {
        var request = new SignInRequest("test@example.com","password");
        var expectedUser = new UserDto { FirstName = "John", LastName = "Doe", Email = "test@example.com" };

        _authServiceMock.Setup(service => service.SignIn(request)).ReturnsAsync(expectedUser);

        var result = await _authService.SignIn(request);

        ClassicAssert.NotNull(result);
        ClassicAssert.AreEqual(expectedUser.Email, result.Email);
    }

    [Test]
    public async Task SignIn_InvalidRequest_ThrowsException()
    {
        var request = new SignInRequest("", "");

        Assert.ThrowsAsync<ArgumentException>(() => _authService.SignIn(request));
    }

    [Test]
    public async Task SignUp_ValidRequest_ReturnsUserDto()
    {
        var request = new SignUpRequest("test@example.com", "password", "John", "Doe");
        var expectedUser = new UserDto { FirstName = "John", LastName = "Doe", Email = "test@example.com" };

        _authServiceMock.Setup(service => service.SignUp(request)).ReturnsAsync(expectedUser);

        var result = await _authService.SignUp(request);

        ClassicAssert.NotNull(result);
        ClassicAssert.AreEqual(expectedUser.Email, result.Email);
    }

    [Test]
    public async Task SignUp_InvalidRequest_ThrowsException()
    {
        var request = new SignUpRequest("", "", "", "");

        Assert.ThrowsAsync<ArgumentException>(() => _authService.SignUp(request));
    }
}