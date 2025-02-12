using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.Group;

namespace WhereIsMyMoney.DAL.Entities.UserManagement;

public record User(string FirstName, string LastName, string Email, string Password) : EntityBase
{
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
    public string FullName => $"{FirstName} {LastName}";
    public string Email { get; set; } = Email;
    public string Password { get; set; } = Password;
    public string Salt { get; set; }
    public string IsDeleted { get; set; }
    public ICollection<PaymentGroup> PaymentGroups { get; set; }
}