using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Interface
{
    public interface ITagRepository : IRepository<Tag>
    {
        public Tag Get(string name);
    }
}
