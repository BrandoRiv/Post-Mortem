using Microsoft.AspNetCore.Identity;
using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class User : IdentityUser, IEntity
    {
        public User() { }
        public User(string username, string bio)
        {
            Username = username;
            Bio = bio;
        }

        public string Username { get; set; }
        public string Bio { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string EntityType => throw new NotImplementedException();
    }
}
