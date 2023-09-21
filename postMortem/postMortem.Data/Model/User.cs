using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class User : Entity
    {
        public User() { }
        public User(string username, string email, string password, UserType role, string bio)
        {
            Username = username;
            Email = email;
            Password = password;
            Role = role;
            Bio = bio;
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Role { get; set; }
        public string Bio { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public override string EntityType => "User";
    }
}
