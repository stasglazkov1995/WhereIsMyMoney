namespace WhereIsMyMoney.DomainModels.Auth.Requests;

public record SignUpRequest(string FirstName, string LastName, string Email, string Password);