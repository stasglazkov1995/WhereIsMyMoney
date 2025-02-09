using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereIsMyMoney.DAL.Entities.Abstract;

namespace WhereIsMyMoney.DAL.Entities.User
{
    public record class User : EntityBase
    {
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")]
        public required string Email { get; set; }
        public required string Password { get; set; }
        
        [StringLength(50)]
        public required string FirstName { get; set; }
        
        [StringLength(50)] 
        public required string LastName { get; set; }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

    }
}
