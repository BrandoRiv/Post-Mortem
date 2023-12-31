﻿using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository
{
    public class PostRepository : postMortemRepository<Post>, IPostRepository
    {
        public PostRepository(postMortemContext context) : base(context)
        {
        }

        public List<Post> GetPostsByUser(User user)
        {
            return base.Find(p => p.Owner == user).ToList();
        }
    }
}
