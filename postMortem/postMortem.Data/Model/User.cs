using Microsoft.AspNetCore.Identity;
using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class User : IdentityUser, IEntity
    {
        public User() { }
        public User(string bio)
        {
            Bio = bio;
        }

        [NotMapped]
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Bio { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }

        public DateTime CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string EntityType => throw new NotImplementedException();
    }
}
