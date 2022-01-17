using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SignalRChat.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength(30), MinLength(3)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
