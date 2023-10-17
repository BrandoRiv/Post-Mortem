using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    public class UserRepository : postMortemRepository<User, string>, IUserRepository
    {
        public UserRepository(postMortemContext context) : base(context)
        {
        }

        public User GetByUsername(string username)
        {
            return base.FirstOrDefault(u => u.UserName == username);
        }
    }
}
