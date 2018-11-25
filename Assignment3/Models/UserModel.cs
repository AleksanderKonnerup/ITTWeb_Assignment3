using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StaffInitials { get; set; }
        public string AUId { get; set; }
        [Key]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserCredentials UserCredentials { get; set; }
        public Role Role { get; set; }
    }
}
