namespace WhereIsMyMoney.DomainModels.DTO.User;

public record UserDto
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Token { get; init; }
}