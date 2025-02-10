using System.ComponentModel.DataAnnotations;
using WhereIsMyMoney.DAL.Entities.Abstract;

namespace WhereIsMyMoney.DAL.Entities.User
{
    public record class User : EntityBase
    {
        [Required]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")]
        public required string Email { get; set; }

        public required string Password { get; set; }

        [Required]
        [StringLength(50)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(50)] 
        public required string LastName { get; set; }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

    }
}
