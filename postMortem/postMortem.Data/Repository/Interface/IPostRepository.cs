﻿using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        public List<Post> GetPostsByUser(User user);
    }
}
