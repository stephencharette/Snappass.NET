using System.Collections.Generic;

namespace Snappass.Models
{
    public class UserModel
    {
        public string UserId { get; set; }
        public List<GeneratedPassword> Secrets { get; set; }
    }
}