﻿using postMortem.Data.Model;
using postMortem.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Instance
{
    public class TagRepository : postMortemRepository<Tag>, ITagRepository
    {
        public TagRepository(postMortemContext context) : base(context)
        {
        }

        public Tag Get(string name)
        {
            return base.FirstOrDefault(r => r.Name.ToLower() == name.ToLower());
        }
    }
}
