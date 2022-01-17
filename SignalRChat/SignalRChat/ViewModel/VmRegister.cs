using System.ComponentModel.DataAnnotations;

namespace SignalRChat.ViewModel
{
    public class VmRegister
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
    }
}
