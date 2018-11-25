using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class UserCredentials
    {
        [Key]
        public string Email { get; set; }
        public string Hash { get; set; }
        public byte[] Salt { get; set; }
    }
}
