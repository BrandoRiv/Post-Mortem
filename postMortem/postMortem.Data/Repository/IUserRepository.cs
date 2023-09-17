using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUsername(string username);
    }
}
