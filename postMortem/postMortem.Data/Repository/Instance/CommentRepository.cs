using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Instance
{
    public class CommentRepository : EfRepository<postMortemContext, Comment>
    {
        public CommentRepository(postMortemContext context) : base(context)
        {
        }
    }
}
